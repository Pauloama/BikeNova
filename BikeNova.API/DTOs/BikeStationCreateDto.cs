using BikeNova.API.Models;

namespace BikeNova.API.DTOs;


public class BikeStationCreateDto
{
    public string Location { get; private set; } = string.Empty;
    public ICollection<Bike>? Bikes { get; private set; }
    public int Vacancies { get; private set; }
}