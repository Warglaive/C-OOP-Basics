
using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
        var input = Console.ReadLine();
        var badgesCount = 0;
        ReadInputAddToResult(input, trainers);
        var currentElement = Console.ReadLine();
        WorkWithElements(currentElement, trainers);
        Print(trainers);
    }

    private static void WorkWithElements(string currentElement, Dictionary<string, Trainer> trainers)
    {
        while (currentElement != "End")
        {
            foreach (var currentTrainer in trainers.Values)
            {
                if (currentTrainer
                    .Pokemons
                    .Any(e => e.Element == currentElement))
                {
                    currentTrainer.Badges++;
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

    private static void ReadInputAddToResult(string input, Dictionary<string, Trainer> trainers)
    {
        while (input != "Tournament")
        {
            var inputArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var trainerName = inputArgs[0];
            var currentPokemon = new Pokemon();
            currentPokemon.Name = inputArgs[1];
            currentPokemon.Element = inputArgs[2];
            currentPokemon.Health = int.Parse(inputArgs[3]);
            if (!trainers.ContainsKey(trainerName))
            {
                trainers[trainerName] = new Trainer(trainerName);
            }
            trainers[trainerName].Pokemons.Add(currentPokemon);
            input = Console.ReadLine();
        }
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

    private static void Print(Dictionary<string, Trainer> trainers)
    {
        foreach (var currentTrainer in trainers.Values.OrderByDescending(x => x.Badges))
        {
            Console.WriteLine($"{currentTrainer.Name} " +
                              $"{currentTrainer.Badges} " +
                              $"{currentTrainer.Pokemons.Count}");
        }
    }
}
