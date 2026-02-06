using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BikeNova.API.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
    public string Username { get; set; } = string.Empty;
    public byte[] PasswordHash { get; set; } = new byte[0];
    public byte[] PasswordSalt { get; set; } = new byte[0];
}