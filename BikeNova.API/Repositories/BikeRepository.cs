using BikeNova.API.Data;
using BikeNova.API.Repositories.Interfaces;
using BikeNova.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeNova.API.Repositories;

public class BikeRepository : IBikeRepository
{
    private readonly BikeNovaContext _context;

    public BikeRepository(BikeNovaContext context)
    {
        _context = context;
    }

    public async Task<List<Bike>> GetAll()
    {
        return await _context.Bikes.ToListAsync();
    }

    public async Task<Bike?> GetById(int id)
    {
        return await _context.Bikes.FindAsync(id);
    }

    public async Task<Bike> Add(Bike bike)
    {
        await _context.Bikes.AddAsync(bike);
        await _context.SaveChangesAsync();
        return bike;
    }

    public async Task<Bike> Update(Bike bike)
    {
        _context.Bikes.Update(bike);
        await _context.SaveChangesAsync();
        return bike;
    }

    public async Task<bool> Delete(int id)
    {
        var bike = await _context.Bikes.FindAsync(id);
        if (bike == null) return false;
        _context.Bikes.Remove(bike);
        await _context.SaveChangesAsync();
        return true;
    }
}