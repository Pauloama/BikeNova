using BikeNova.API.Enums;
using BikeNova.API.Models;

namespace BikeNova.API.DTOs;

public class BikeCreateDto
{
    private string Name { get; set; } = string.Empty;
    private bool Unlocked { get; set; } = false;
    private BikePlans UseTime { get; set; }
    private BikeStation? BikeStation { get; set; }
}