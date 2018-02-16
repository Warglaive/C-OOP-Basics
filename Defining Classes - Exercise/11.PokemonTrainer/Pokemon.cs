using System;
using System.Collections.Generic;
using System.Text;


public class Pokemon
{
    private string name;
    private string element;
    private int health;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Element
    {
        get => element;
        set => element = value;
    }

    public int Health
    {
        get => health;
        set => health = value;
    }
}
