using System;
using System.Collections.Generic;
using System.Text;


public interface IVehicle
{
    double FuelQuantity { get; }
    double FuelConsumePerKm { get; }
    double TankCapacity { get; }
    void Drive(double distance);
    void Refuel(double tankCapacity, double liters);
}