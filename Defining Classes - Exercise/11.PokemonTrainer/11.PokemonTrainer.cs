using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var result = new List<Trainer>();
        var badgesCount = 0;
        bool isUnique = true;
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
            currentPokemon.Health = int.Parse(inputArgs[3]);
            //unique trainer check
            foreach (var trainerInList in result)
            {
                if (trainerInList.TrainerName == trainerName)
                {
                    trainerInList.Pokemons.Add(currentPokemon);
                    isUnique = false;
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
        var currentElement = Console.ReadLine();
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
                //health check
                // var tempList = new List<Trainer>(result);
                for (int i = 0; i < currentTrainer.Pokemons.Count; i++)
                {
                    if (currentTrainer.Pokemons[i].Health <= 0)
                    {
                        currentTrainer.Pokemons.Remove(currentTrainer.Pokemons[i]);
                    }
                }
            }
            currentElement = Console.ReadLine();
        }
        //Print
        foreach (var currentTrainer in result.OrderByDescending(x=>x.BadgesCount))
        {
            Console.WriteLine($"{currentTrainer.TrainerName} " +
                              $"{currentTrainer.BadgesCount} " +
                              $"{currentTrainer.Pokemons.Count}");
        }
    }
}