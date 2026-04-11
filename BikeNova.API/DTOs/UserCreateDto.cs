using BikeNova.API.Models;
using System.ComponentModel.DataAnnotations;
using BikeNova.API.Enums;

namespace BikeNova.API.DTOs;

public class UserCreateDto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
    public string Username { get; private set; } = string.Empty;
    public byte[] PasswordHash { get; private set; } = new byte[0];
    public byte[] PasswordSalt { get; private set; } = new byte[0];
    public BikePlans Plan { get; private set; }

    public void SetPassword(byte[] passwordHash, byte[] passwordSalt)
    {

        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
    }
}
