using BikeNova.API.Models;

namespace BikeNova.API.Repositories.Interfaces;

public interface IUserRepository
{
    Task<User?> GetById(int id);
    Task<User> Add(User user);
    Task<User> Update(User user);
    Task<bool> Delete(int id);
}