using BikeNova.API.Models;

namespace BikeNova.API.DTOs;


public class BikeStationCreateDto
{
    public string Location { get; set; } = string.Empty;
    public ICollection<Bike>? Bikes { get; set; }
    public int Vacancies { get; set; }
}