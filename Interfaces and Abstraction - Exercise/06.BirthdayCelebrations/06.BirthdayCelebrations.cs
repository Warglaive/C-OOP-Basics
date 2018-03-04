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

            if (inputArgs[0] == "Citizen")
            {
                var name = inputArgs[1];
                var age = inputArgs[2];
                var id = inputArgs[3];
                var birthday = inputArgs[4];
                var citizen = new Citizens(name, age, id, birthday);
                members.Add(citizen);
                //

            }
            else if (inputArgs[0] == "Robot")
            {
                var model = inputArgs[1];
                var robotId = inputArgs[2];
                var birthDay = string.Empty;
                var robot = new Robots(model, robotId, birthDay);
                members.Add(robot);
            }
            else//pet
            {
                var petName = inputArgs[1];
                var id = string.Empty;
                var petBirthday = inputArgs[2];
                var pet = new Pet(petName, id, petBirthday);
                members.Add(pet);
            }
            input = Console.ReadLine();
        }
        var lastDigits = Console.ReadLine();
        var result = members.Where(m => m.HasInvalidEnding(lastDigits));
        foreach (var toBeGifted in result)
        {
            Console.WriteLine(toBeGifted.BirthDay);
        }
    }
}
