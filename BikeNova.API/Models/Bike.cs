using System.ComponentModel.DataAnnotations;
using BikeNova.API.Enums;

namespace BikeNova.API.Models;

public class Bike
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Unlocked { get; set; } = false;
    public BikePlans UseTime { get; set; }
    public BikeStation? BikeStation { get; set; }
}