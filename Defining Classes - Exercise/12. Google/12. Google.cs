using System;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();

        while (input != "End")
        {
            var inputArgs = input.Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            //person, company,car -- unique
            //parents,children,pokemons--multiple

            input = Console.ReadLine();
        }
    }
}

