using BikeNova.API.Models;

namespace BikeNova.API.Repositories.Interfaces;

public interface IBikeStationRepository
{
    Task<List<BikeStation>> GetAll();
    Task<BikeStation?> GetById(int id);
    Task<BikeStation> Add(BikeStation bikeStation);
    Task<BikeStation> Update(BikeStation bikeStation);
    Task<bool> Delete(int id);
}