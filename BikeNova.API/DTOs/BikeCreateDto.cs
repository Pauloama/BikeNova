using BikeNova.API.Enums;
using BikeNova.API.Models;

namespace BikeNova.API.DTOs;

public class BikeCreateDto
{
    public string Name { get; private set; } = string.Empty;
    public bool Unlocked { get; private set; } = false;
    public BikePlans UseTime { get; private set; }
    public BikeStation? BikeStation { get; private set; }
}