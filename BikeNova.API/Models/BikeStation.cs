namespace BikeNova.API.Models;

public class BikeStation
{
    public int Id { get; set; }
    public string Location { get; set; } = string.Empty;
    public ICollection<Bike> Bikes { get; set; } = new List<Bike>();

    public int Capacity { get; set; } = 20;
    public int Vacancies => Capacity - Bikes.Count;
}