using System.Collections.Generic;


public class Trainer
{
    private string trainerName;
    private decimal badgesCount;
    private List<Pokemon> pokemons;

    public string TrainerName
    {
        get => trainerName;
        set => trainerName = value;
    }
    public decimal BadgesCount
    {
        get => badgesCount;
        set => badgesCount = value;
    }

    public List<Pokemon> Pokemons
    {
        get => pokemons;
        set => pokemons = value;
    }

    public Trainer(string TrainerName, decimal BadgesCount, List<Pokemon> Pokemons)
    {
        this.trainerName = TrainerName;
        this.badgesCount = BadgesCount;
        this.pokemons = Pokemons;
    }
}