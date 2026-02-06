using AutoMapper;
using BikeNova.API.DTOs;
using BikeNova.API.Models;

namespace BikeNova.API.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserRegisterDto, User>();
    }
}