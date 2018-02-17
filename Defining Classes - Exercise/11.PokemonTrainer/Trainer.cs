using System;
using System.Collections.Generic;
using System.Text;


public class Trainer
{
    private string trainerName;
    private int badgesCount;
    private List<Pokemon> pokemons;

    public string TrainerName
    {
        get => trainerName;
        set => trainerName = value;
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

    public Trainer(string TrainerName, int BadgesCount, List<Pokemon> Pokemons)
    {
        this.trainerName = TrainerName;
        this.badgesCount = BadgesCount;
        this.pokemons = Pokemons;
    }
}