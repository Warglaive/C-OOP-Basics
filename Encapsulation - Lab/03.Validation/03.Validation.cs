using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0],
                cmdArgs[1],
                int.Parse(cmdArgs[2]),
                decimal.Parse(cmdArgs[3]));
            var firstName = cmdArgs[0];
            var lastName = cmdArgs[1];
            var currentSalary = decimal.Parse(cmdArgs[3]);
            var currentAge = int.Parse(cmdArgs[2]);
            persons.Add(person);
        }
        var bonus = decimal.Parse(Console.ReadLine());
        persons.ForEach(p => p.IncreaseSalary(bonus));
        persons.ForEach(p => Console.WriteLine(p.ToString()));


        persons.ForEach(p => p.validateAge(p.Age));
        persons.ForEach(p => p.ValidateFirstName(p.FirstName));
        persons.ForEach(p => p.ValidateLastName(p.LastName));
        persons.ForEach(p => p.ValidateSalary(p.Salary));

    }
}
