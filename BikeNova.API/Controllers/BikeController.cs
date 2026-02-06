using AutoMapper;
using BikeNova.API.DTOs;
using BikeNova.API.Models;
using BikeNova.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BikeNova.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BikeController : ControllerBase
{
    private readonly IBikeRepository _repository;
    private readonly IMapper _mapper;
    public BikeController(IBikeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var bikes = await _repository.GetAll();

        var bikesDto = _mapper.Map<List<BikeResponseDto>>(bikes);

        return Ok(bikesDto);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var bike = await _repository.GetById(id);
        
        if (bike == null) return NotFound();

        var bikeDto = _mapper.Map<BikeResponseDto>(bike);

        return Ok(bikeDto);
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateBike(BikeCreateDto bikeDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var bike = _mapper.Map<Bike>(bikeDto);
        
        await _repository.Add(bike);

        return CreatedAtAction(nameof(GetById), new {id = bike.Id}, bike);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, BikeCreateDto bikeDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var bike = await _repository.GetById(id);
        if (bike == null) return NotFound();

        _mapper.Map(bikeDto, bike);

        await _repository.Update(bike);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<BikeResponseDto>> Delete(int id)
    {

            var deletedBike = await _repository.Delete(id);
            if (!deletedBike)
            {
                return NotFound("Bike não encontrada!");
            }
            return NoContent();
    }
}

