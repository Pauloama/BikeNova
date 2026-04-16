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
    public BikePlans Plan { get; private set; }
}
