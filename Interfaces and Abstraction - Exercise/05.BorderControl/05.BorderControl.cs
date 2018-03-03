using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var members = new List<SocietyMembersId>();

        while (input != "End")
        {
            var inputArgs = input.Split();
            if (inputArgs.Length == 2)
            {
                var model = inputArgs[0];
                var robotId = inputArgs[1];
                var robot = new Robots(model, robotId);
                members.Add(robot);
            }
            else
            {
                var name = inputArgs[0];
                var age = inputArgs[1];
                var id = inputArgs[2];

                var citizen = new Citizens(name, age, id);
                members.Add(citizen);
            }
            input = Console.ReadLine();
        }
        var lastDigits = Console.ReadLine();
        var result = members.Where(m => m.HasInvalidEnding(lastDigits) == true);
        foreach (var toBeKilled in result)
        {
            Console.WriteLine(toBeKilled.Id);
        }
    }
}