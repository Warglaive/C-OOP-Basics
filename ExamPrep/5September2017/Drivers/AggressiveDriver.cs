﻿using System;
using System.Collections.Generic;
using System.Text;

public class AggressiveDriver : Driver
{
    public AggressiveDriver(string name, Car car,
        double fuelConsumptionPerKm)
        : base(name, car, 2.7)
    {
    }

    protected override double Speed => base.Speed * 1.3;
}