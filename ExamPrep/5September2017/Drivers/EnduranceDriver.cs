﻿using System;
using System.Collections.Generic;
using System.Text;


public class EnduranceDriver : Driver
{
    public EnduranceDriver(string name, Car car)
    : base(name, car)
    {
        this.FuelConsumptionPerKm = 1.5;
    }
}