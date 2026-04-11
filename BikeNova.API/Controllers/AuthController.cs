using AutoMapper;
using BikeNova.API.DTOs;
using BikeNova.API.Models;
using BikeNova.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BikeNova.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthRepository _repository;  
    private readonly IMapper _mapper;

    private readonly IUserRepository _userRepository;

    public AuthController(IAuthRepository repository, IMapper mapper, IUserRepository userRepository)
    {
        _repository = repository;
        _mapper = mapper;
        _userRepository = userRepository;
    }

    [HttpPost("register")]
    public async Task<ActionResult> Register(UserRegisterDto userDto)
    {
        var userToBe = _mapper.Map<User>(userDto);
        try
        {
            var userId = await _repository.Register(userToBe, userDto.Password);
            return CreatedAtAction(nameof(_userRepository.GetById), new {id = userId}, userToBe);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(UserLoginDto userDto)
    {
        try
        {
            var token = await _repository.Login(userDto.Username, userDto.Password);

            if (token == "Usuário não encontrado." || token == "Senha incorreta.")
                return BadRequest(token);

            return Ok(new {token});
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro ao realizar login: {ex.Message}");
        }
    }
}