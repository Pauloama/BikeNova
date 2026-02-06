using AutoMapper;
using BikeNova.API.DTOs;
using BikeNova.API.Models;

public class BikeStationProfile : Profile
{
    public BikeStationProfile()
    {
        CreateMap<BikeStationCreateDto, BikeStation>();
        CreateMap<BikeStation, BikeStationResponseDto>();
    }
}