using System;
using System.Collections.Generic;
using System.Text;


public class Trainer
{
    private string name;
    private int badgesCount;
    private List<Pokemon> pokemons;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int BadgesCount
    {
        get => badgesCount;
        set => badgesCount = value;
    }

    public List<Pokemon> Pokemons
    {
        get => pokemons;
        set => pokemons = value;
    }
}
