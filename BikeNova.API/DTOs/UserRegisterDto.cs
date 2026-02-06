using System.ComponentModel.DataAnnotations;
using AutoMapper;
using BikeNova.API.Models;

namespace BikeNova.API.DTOs;
public class UserRegisterDto
{
    [Required(ErrorMessage = "O nome de usuário é obrigatório!")]
    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage = "A senha é obrigatória!")]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "A senha deve ter no mínimo 8 caracteres")]
    public string Password { get; set; } = string.Empty;
}