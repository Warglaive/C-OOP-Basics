using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var members = new List<SocietyMembersId>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            var inputArgs = input.Split();

            if (inputArgs.Length == 4) //citizen
            {
                var name = inputArgs[0];
                var age = int.Parse(inputArgs[1]);
                var id = inputArgs[2];
                var birthday = inputArgs[3];
                var food = 0;
                var citizen = new Citizens(name, age, id, birthday, food);
                members.Add(citizen);

            }
            else//rebel
            {
                var name = inputArgs[0];
                var age = int.Parse(inputArgs[1]);
                var id = string.Empty;
                var birthday = string.Empty;
                var group = inputArgs[2];
                var food = 0;
                var rebel = new Rebel(name, age, id, birthday, group, food);
                members.Add(rebel);
            }
        }
        var currentBuyer = Console.ReadLine();
        while (currentBuyer != "End")
        {
            foreach (var currentMember in members)
            {
                if (currentMember.Name == currentBuyer)
                {
                    if (currentMember is Rebel)
                    {
                        currentMember.Food += 5;
                    }
                    else
                    {
                        currentMember.Food += 10;
                    }
                }
            }
            currentBuyer = Console.ReadLine();
        }
        var totalFood = members.Sum(m => m.Food);
        Console.WriteLine(totalFood);
    }
}