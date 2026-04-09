using BikeNova.API.Enums;

namespace BikeNova.API.DTOs;

public class BikeResponseDto
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public bool Unlocked {get; private set;} = false;
    public BikePlans UseTime {get; private set;}
}