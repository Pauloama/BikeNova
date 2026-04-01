namespace BikeNova.API.Models;

public class BikeStation
{
    private int Id { get; set; }
    private string Location { get; set; } = string.Empty;
    private ICollection<Bike> Bikes { get; set; } = new List<Bike>();

    private int Capacity { get; set; } = 20;
    private int Vacancies => Capacity - Bikes.Count ;

    public int GetVacancies()
    {
        return Vacancies;
    }
}