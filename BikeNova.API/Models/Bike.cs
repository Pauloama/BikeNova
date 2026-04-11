using System.ComponentModel.DataAnnotations;
using BikeNova.API.Enums;

namespace BikeNova.API.Models;

public class Bike
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public bool Unlocked { get; private set; } = false;
    public BikePlans UseTime { get; private set; }
    public BikeStation? BikeStation { get; private set; }

    public Bike(){}

    public Bike(string name, BikePlans useTime)
    {
        Name = name;
        UseTime = useTime;
        Unlocked = false;
    }
}