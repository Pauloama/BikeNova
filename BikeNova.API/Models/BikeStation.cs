namespace BikeNova.API.Models;

public class BikeStation
{
    public int Id { get; private set; }
    public string Location { get; private set; } = string.Empty;
    public ICollection<Bike> Bikes { get; private set; } = new List<Bike>();

    public int Capacity { get; private set; } = 20;
    public int Vacancies => Capacity - Bikes.Count ;

    public int GetVacancies()
    {
        return Vacancies;
    }
}