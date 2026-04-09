using BikeNova.API.Models;

namespace BikeNova.API.DTOs;

public class BikeStationResponseDto
{
    public int Id { get; private set; }
    public string Location { get; private set; } = string.Empty;
    public ICollection<Bike>? Bikes { get; private set; }
    public int Vacancies { get; private set; }
}