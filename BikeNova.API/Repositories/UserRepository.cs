using BikeNova.API.Models;
using BikeNova.API.Repositories.Interfaces;
using BikeNova.API.Data;
using Microsoft.EntityFrameworkCore;  

namespace BikeNova.API.Repositories;

public class UserRepository : IUserRepository
{
    private readonly BikeNovaContext _context;

    public UserRepository(BikeNovaContext context)
    {
        _context = context;
    }
    public async Task<User?> GetById(int id)
    {
        var user = await _context.Users.FindAsync(id);
        return user;
    }

    public async Task<User> Add(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User> Update(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<bool> Delete(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return false;

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return true;
    }
}