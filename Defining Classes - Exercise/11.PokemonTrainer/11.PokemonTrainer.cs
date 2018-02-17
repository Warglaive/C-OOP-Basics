using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        //dictionary trainer - key, pokemonsList-value
        var result = new Dictionary<string, List<Pokemon>>();
        var input = Console.ReadLine();
        while (input != "Tournament")
        {
            var currentTrainer = new Trainer();
            var currentPokemon = new Pokemon();

            var inputArgs = input.Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var currentTrainerName = inputArgs[0];
            currentTrainer.Name = inputArgs[0];

            currentPokemon.Name = inputArgs[1];
            currentPokemon.Element = inputArgs[2];
            currentPokemon.Health = int.Parse(inputArgs[3]);
            if (!result.ContainsKey(currentTrainerName))
            {
                result.Add(currentTrainerName, new List<Pokemon>());
            }
            result[currentTrainerName].Add(currentPokemon);

            input = Console.ReadLine();
        }
        var currentElement = Console.ReadLine();
        while (currentElement != "End")
        {
            //if a trainer has at least 1 pokemon with the given element
            foreach (var currentTrainer in result)
            {
                //var filterElements = currentTrainer
                //    .Value.Where(e => e.Element == currentElement).Any();
                if (currentTrainer
                    .Value.Where(e => e.Element == currentElement).Any())
                {

                }
            }
            currentElement = Console.ReadLine();
        }
    }
}