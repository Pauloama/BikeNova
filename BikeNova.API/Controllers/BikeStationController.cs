using AutoMapper;
using BikeNova.API.DTOs;
using BikeNova.API.Models;
using BikeNova.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BikeNova.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BikeStationController : ControllerBase
{
    private readonly IBikeStationRepository _repository;
    private readonly IMapper _mapper;

    public BikeStationController(IBikeStationRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var bikeStations = await _repository.GetAll();

        var bikeStationsDto = _mapper.Map<List<BikeResponseDto>>(bikeStations);
        
        return Ok(bikeStationsDto);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var bikeStation = await _repository.GetById(id);
        
        var bikeStationDto = _mapper.Map<BikeResponseDto>(bikeStation);
        
        return Ok(bikeStationDto);
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Create(BikeStationCreateDto bikeStationDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var bikeStation = _mapper.Map<BikeStation>(bikeStationDto);

        await _repository.Add(bikeStation);
        
        return CreatedAtAction(nameof(GetById), new {id = bikeStation.Id}, bikeStation);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, BikeStationCreateDto bikeStationDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var bikeStation = await _repository.GetById(id);
        if (bikeStation == null) return NotFound();

        _mapper.Map(bikeStationDto, bikeStation);

        await _repository.Update(bikeStation);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<BikeStationCreateDto>> Delete(int id)
    {
        try
        {
            var deletedBikeStation = await _repository.Delete(id);
            if (!deletedBikeStation)
            {
                return NotFound("Estação de Bike não encontrada.");
            }
            return NoContent();
        }
        catch (Exception)
        {
            return BadRequest("Não é possível apagar essa estação de bike pois ela possui bikes adicionadas à ela.");
        }
    }
}