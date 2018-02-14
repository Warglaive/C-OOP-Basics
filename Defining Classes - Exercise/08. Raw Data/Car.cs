using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
public class Car
{
    //model, engine, cargo and a collection of exactly 4 tires
    private string model;
    private Tire tires;
    private Engine engine;
    private Cargo cargo;

    public Car(string model, Tire tires, Engine engine, Cargo cargo)
    {
        this.model = model;
        this.tires = tires;
        this.engine = engine;
        this.cargo = cargo;
    }

    public string Model
    {
        get { return this.model; }
    }

    public Tire Tires
    {
        get { return this.tires; }
    }

    public Engine Engine
    {
        get { return this.engine; }
    }

    public Cargo Cargo
    {
        get { return this.cargo; }
    }
}
