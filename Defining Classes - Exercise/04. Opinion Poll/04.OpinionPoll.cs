using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var result = new List<Person>();
        var currentPerson = new Person();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            var inputArgs = input.Split();
            var name = inputArgs[0];
            var age = int.Parse(inputArgs[1]);

            currentPerson = new Person();
            currentPerson.Name = name;
            currentPerson.Age = age;
            if (currentPerson.Age > 30)
            {
                result.Add(currentPerson);
            }
        }
        foreach (var currentPersonP in result.OrderBy(a => a.Name))
        {
            Console.WriteLine($"{currentPersonP.Name} - {currentPersonP.Age}");
        }
    }
}

