using AutoMapper;
using BikeNova.API.DTOs;
using BikeNova.API.Models;

namespace BikeNova.API.Profiles;

public class BikeProfile : Profile
{
    public BikeProfile()
    {
        CreateMap<BikeCreateDto, Bike>();
        CreateMap<Bike, BikeResponseDto>();
    }
}