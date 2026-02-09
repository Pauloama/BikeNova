using BikeNova.API.Data;
using BikeNova.API.Models;
using BikeNova.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BikeNova.API.Repositories;

public class BikeStationRepository : IBikeStationRepository
{
    private readonly BikeNovaContext _context;

    public BikeStationRepository(BikeNovaContext context)
    {
        _context = context;
    }

    public async Task<List<BikeStation>> GetAll()
    {
        return await _context.BikeStations.ToListAsync();
    }

    public async Task<BikeStation?> GetById(int id)
    {
        return await _context.BikeStations.FindAsync(id);
    }

    public async Task<BikeStation> Add(BikeStation bikeStation)
    {
        await _context.BikeStations.AddAsync(bikeStation);
        await _context.SaveChangesAsync();
        return bikeStation;
    }

    public async Task<BikeStation> Update(BikeStation bikeStation)
    {
        _context.BikeStations.Update(bikeStation);
        await _context.SaveChangesAsync();
        return bikeStation;
    }

    public async Task<bool> Delete(int id)
    {
        var bikeStation = await _context.BikeStations.FindAsync(id);
        if (bikeStation == null) return false;
        _context.BikeStations.Remove(bikeStation);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<BikeStation?> AddBike(int stationId, int bikeId)
    {
        var station = await _context.BikeStations
        .Include(s => s.Bikes)
        .FirstOrDefaultAsync(s => s.Id == stationId);
        if (station == null) return null;

        if (station.Bikes.Count() >= 20)
        {
            throw new InvalidOperationException("O número máximo de bicicletas nesta estação foi atingido");
        }

        else
        {

            var bike = await _context.Bikes.FindAsync(bikeId);
            if (bike == null) throw new KeyNotFoundException("Bicicleta não encontrada.");

            bool bikeAlreadyOnStation = station.Bikes.Any(b => b.Id == bikeId);

            if (bikeAlreadyOnStation)
            {
                throw new InvalidOperationException("Esta bicicleta já está nesta estação.");
            }

            station.Bikes.Add(bike);

            await _context.SaveChangesAsync();

            return station;
        }
    }

    public async Task<BikeStation?> RemoveBike(int stationId, int bikeId)
    {
        var station = await _context.BikeStations
        .Include(s => s.Bikes)
        .FirstOrDefaultAsync(s => s.Id == stationId);
        if (station == null) return null;

        if (station.Bikes.Count() <= 0)
        {
            throw new InvalidOperationException("Não há bicicletas nessa estação.");
        }


        var bikeToRemove = station.Bikes.FirstOrDefault(b => b.Id == bikeId);
        if (bikeToRemove == null) throw new KeyNotFoundException("Bicicleta não encontrada.");

        bool bikeAlreadyOnStation = station.Bikes.Any(b => b.Id == bikeId);

        if (!bikeAlreadyOnStation)
        {
            throw new InvalidOperationException("Esta bicicleta não está mais na estação.");
        }

        station.Bikes.Remove(bikeToRemove);

        await _context.SaveChangesAsync();

        return station;
    }
}