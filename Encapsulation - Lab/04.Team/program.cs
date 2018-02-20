using System;

public class Program
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var teams = new Team(string.Empty);
        for (var i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0],
                cmdArgs[1],
                int.Parse(cmdArgs[2]),
                decimal.Parse(cmdArgs[3]));
            teams.AddPlayer(person);

        }
        Console.WriteLine($"First team has {teams.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {teams.ReverseTeam.Count} players.");
    }
}