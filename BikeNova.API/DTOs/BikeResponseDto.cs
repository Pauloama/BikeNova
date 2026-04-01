using BikeNova.API.Enums;

namespace BikeNova.API.DTOs;

public class BikeResponseDto
{
    private int Id { get; set; }
    private string Name { get; set; } = string.Empty;
    private bool Unlocked {get;set;} = false;
    private BikePlans UseTime {get;set;}
}