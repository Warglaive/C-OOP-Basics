using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var linesCount = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int index = 0; index < linesCount; index++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var currentPerson = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
            persons.Add(currentPerson);
        }

        persons.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));

    }
}

