using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private Company company;
    private List<Pokemon> pokemons;
    private List<Parents> parents;
    private List<Children> children;
    private Car car;

    public Company Company
    {
        get => company;
        set => company = value;
    }

    public List<Pokemon> Pokemon
    {
        get => pokemons;
        set => pokemons = value;
    }
    public List<Parents> Parents
    {
        get => parents;
        set => parents = value;
    }

    public List<Children> Children
    {
        get => children;
        set => children = value;
    }

    public Car Car
    {
        get => car;
        set => car = value;
    }


    //public Person(Company Company, Parents Parents, Children Children, Car Car)
    //{
    //    this.company = Company;
    //    this.parents = Parents;
    //    this.children = Children;
    //    this.car = Car;
    //}
}