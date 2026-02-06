using BikeNova.API.Enums;

namespace BikeNova.API.DTOs;

public class BikeResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Unlocked {get;set;} = false;
    public BikePlans UseTime {get;set;}
}