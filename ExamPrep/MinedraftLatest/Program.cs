using System;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var draftManager = new DraftManager();
        var input = Console.ReadLine();

        while (input != "Shutdown")
        {
            try
            {
                var commands = input.Split();
                var command = commands[0];
                var arguments = commands.Skip(1).ToList();
                switch (command)
                {
                    case "RegisterHarvester":
                        Console.WriteLine(draftManager.RegisterHarvester(arguments));
                        break;
                    case "RegisterProvider":
                        Console.WriteLine(draftManager.RegisterProvider(arguments));
                        break;
                    case "Day":
                        Console.WriteLine(draftManager.Day());
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            input = Console.ReadLine();
        }
    }
}