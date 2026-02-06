using BikeNova.API.Models;

namespace BikeNova.API.Repositories.Interfaces;

public interface IAuthRepository
{
    Task<int> Register(User user, string password);
    Task<string> Login(string username, string password);
    Task<bool> ExistingUser(string username);
}