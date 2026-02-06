using BikeNova.API.Models;

namespace BikeNova.API.DTOs;

public class BikeStationResponseDto
{
    public int Id { get; set; }
    public string Location { get; set; } = string.Empty;
    public ICollection<Bike>? Bikes { get; set; }
    public int Vacancies { get; set; }
}