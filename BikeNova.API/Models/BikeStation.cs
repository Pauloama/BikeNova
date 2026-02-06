namespace BikeNova.API.Models;

public class BikeStation
{
    public int Id { get; set; }
    public string Location { get; set; } = string.Empty;
    public ICollection<Bike>? Bikes { get; set; }
    public int Vacancies { get; set; } = 20;
}