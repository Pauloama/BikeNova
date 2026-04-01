using System.ComponentModel.DataAnnotations;
using BikeNova.API.Enums;

namespace BikeNova.API.Models;

public class Bike
{
    private int Id { get; set; }
    private string Name { get; set; } = string.Empty;
    private bool Unlocked { get; set; } = false;
    private BikePlans UseTime { get; set; }
    private BikeStation? BikeStation { get; set; }
}