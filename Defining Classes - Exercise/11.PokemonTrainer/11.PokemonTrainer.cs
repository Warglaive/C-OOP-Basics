using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        //dictionary trainer - key, pokemonsList-value
        var result = new Dictionary<Trainer, List<Pokemon>>();
        var input = Console.ReadLine();
        var pokeList = new List<Pokemon>();
        while (input != "Tournament")
        {
            var currentTrainer = new Trainer();
            var currentPokemon = new Pokemon();

            var inputArgs = input.Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            currentPokemon.Name = inputArgs[1];
            currentPokemon.Element = inputArgs[2];
            currentPokemon.Health = int.Parse(inputArgs[3]);

            pokeList.Add(currentPokemon);

            currentTrainer.Pokemons = pokeList;


            input = Console.ReadLine();
        }
        var elementsInput = Console.ReadLine();
        while (elementsInput != "End")
        {

            elementsInput = Console.ReadLine();
        }
        //Where name != null - print, else - ignore
    }
}