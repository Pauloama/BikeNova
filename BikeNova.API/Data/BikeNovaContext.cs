using Microsoft.EntityFrameworkCore;
using BikeNova.API.Models;

namespace BikeNova.API.Data;

public class BikeNovaContext : DbContext
{
    public BikeNovaContext(DbContextOptions<BikeNovaContext> options) : base(options)
    {
    }

    public DbSet<Bike> Bikes { get; set; }
    public DbSet<BikeStation> BikeStations { get; set; }
    public DbSet<User> Users {get;set;}
}