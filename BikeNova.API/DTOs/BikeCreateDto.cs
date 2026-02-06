using BikeNova.API.Enums;
using BikeNova.API.Models;

namespace BikeNova.API.DTOs;

public class BikeCreateDto
{
    public string Name { get; set; } = string.Empty;
    public bool Unlocked { get; set; } = false;
    public BikePlans UseTime { get; set; }
    public BikeStation? BikeStation { get; set; }
}