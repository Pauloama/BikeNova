using AutoMapper;
using BikeNova.API.DTOs;
using BikeNova.API.Models;
using BikeNova.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BikeNova.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserController(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetById(int id, UserResponseDto userResponseDto)
    {
        var user = await _repository.GetById(id);

        if (user == null) return NotFound();

        var userDto = _mapper.Map<UserResponseDto>(user);

        return Ok(userDto);
    }

    [HttpPost]
    public async Task<ActionResult> CreateUser(UserCreateDto userDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var user = _mapper.Map<User>(userDto);
        
        await _repository.Add(user);

        return CreatedAtAction(nameof(GetById), new {id = user.Id}, user);
    }

    public async Task<ActionResult> Update(int id, UserCreateDto userDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var user = await _repository.GetById(id);
        
        if (user == null) return NotFound();

        _mapper.Map(userDto, user);
        
        await _repository.Update(user);

        return NoContent();
    }

    public async Task<ActionResult> Delete(int id)
    {
        var user = await _repository.GetById(id);
        
        if (user == null) return NotFound();

        await _repository.Delete(id);

        return NoContent();
    }
}