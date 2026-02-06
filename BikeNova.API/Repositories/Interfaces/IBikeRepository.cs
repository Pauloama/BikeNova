using BikeNova.API.Models;

namespace BikeNova.API.Repositories.Interfaces;

public interface IBikeRepository
{
    Task<List<Bike>> GetAll();
    Task<Bike?> GetById(int id);

    Task<Bike> Add(Bike bike);
    Task<Bike> Update(Bike bike);

    Task<bool> Delete(int id);
}