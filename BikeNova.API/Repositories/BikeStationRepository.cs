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
        if(bikeStation == null) return false;
        _context.BikeStations.Remove(bikeStation);
        await _context.SaveChangesAsync();
        return true;
    }
}