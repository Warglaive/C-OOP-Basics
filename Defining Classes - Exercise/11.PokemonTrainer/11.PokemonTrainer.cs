using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var result = new List<Trainer>();
        var badgesCount = 0m;
        var isUnique = true;
        ReadInputAddToResult(input, result, isUnique, badgesCount);
        var currentElement = Console.ReadLine();
        WorkWithElements(currentElement, result);
        //Print
        Print(result);
    }

    private static void WorkWithElements(string currentElement, List<Trainer> result)
    {
        while (currentElement != "End")
        {
            //if a trainer has at least 1 pokemon with the given element
            foreach (var currentTrainer in result)
            {
                if (currentTrainer
                    .Pokemons
                    .Any(e => e.Element == currentElement))
                {
                    currentTrainer.BadgesCount++;
                }
                else
                {
                    foreach (var currentPokemon in currentTrainer.Pokemons)
                    {
                        currentPokemon.Health -= 10;
                    }
                }
                HealthCheck(currentTrainer);
            }
            currentElement = Console.ReadLine();
        }
    }

    private static void ReadInputAddToResult(string input, List<Trainer> result, bool isUnique, decimal badgesCount)
    {
        while (input != "Tournament")
        {
            var pokeList = new List<Pokemon>();
            var currentPokemon = new Pokemon();
            var inputArgs = input.Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var trainerName = inputArgs[0];
            currentPokemon.Name = inputArgs[1];
            currentPokemon.Element = inputArgs[2];
            currentPokemon.Health = decimal.Parse(inputArgs[3]);
            //unique trainer check
            foreach (var trainerInList in result)
            {
                if (trainerInList.TrainerName == trainerName)
                {
                    isUnique = false;
                    trainerInList.Pokemons.Add(currentPokemon);
                }
            }
            if (isUnique)
            {
                pokeList.Add(currentPokemon);

                var currentTrainer = new Trainer(trainerName, badgesCount, pokeList);
                result.Add(currentTrainer);
            }
            input = Console.ReadLine();
        }
        Console.WriteLine();
    }

    private static void HealthCheck(Trainer currentTrainer)
    {
        for (int i = 0; i < currentTrainer.Pokemons.Count; i++)
        {
            if (currentTrainer.Pokemons[i].Health <= 0)
            {
                currentTrainer.Pokemons.Remove(currentTrainer.Pokemons[i]);
            }
        }
    }

    private static void Print(List<Trainer> result)
    {
        foreach (var currentTrainer in result.OrderByDescending(x => x.BadgesCount))
        {
            Console.WriteLine($"{currentTrainer.TrainerName} " +
                              $"{currentTrainer.BadgesCount} " +
                              $"{currentTrainer.Pokemons.Count}");
        }
    }
}