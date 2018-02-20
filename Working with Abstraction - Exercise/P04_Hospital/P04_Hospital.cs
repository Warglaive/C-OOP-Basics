using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var doctors = new Dictionary<string, List<string>>();
        var departments = new Dictionary<string, List<List<string>>>();
        var command = Console.ReadLine();
        while (command != "Output")
        {
            var commandArgs = command.Split();
            var departament = commandArgs[0];
            var docFirstName = commandArgs[1];
            var docSecondName = commandArgs[2];
            var patient = commandArgs[3];
            var doctorFullName = docFirstName + docSecondName;

            if (!doctors.ContainsKey(docFirstName + docSecondName))
            {
                doctors[doctorFullName] = new List<string>();
            }
            if (!departments.ContainsKey(departament))
            {
                departments[departament] = new List<List<string>>();
                for (var roomsCount = 0; roomsCount < 20; roomsCount++)
                {
                    departments[departament].Add(new List<string>());
                }
            }

            var enoughtRooms = departments[departament].SelectMany(x => x).Count() < 60;
            if (enoughtRooms)
            {
                var currentRoom = 0;
                doctors[doctorFullName].Add(patient);
                for (var bedCount = 0; bedCount < departments[departament].Count; bedCount++)
                {
                    if (departments[departament][bedCount].Count >= 3) continue;
                    currentRoom = bedCount;
                    break;
                }
                departments[departament][currentRoom].Add(patient);
            }

            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "End")
        {
            var args = command.Split();

            switch (args.Length)
            {
                case 1:
                    Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                    break;
                case 2 when int.TryParse(args[1], out int staq):
                    Console.WriteLine(string.Join("\n", departments[args[0]][staq - 1].OrderBy(x => x)));
                    break;
                default:
                    Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
                    break;
            }
            command = Console.ReadLine();
        }
    }
}
