using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var draftManager = new DraftManager();
        var inputCommands = Console.ReadLine()
            .Split().ToList();
        var command = inputCommands[0];
        switch (command)
        {
            case "RegisterHarvester":
                Console.WriteLine(draftManager.RegisterHarvester(inputCommands));
                break;
            case "RegisterProvider":
                Console.WriteLine(draftManager.RegisterProvider(inputCommands));
                break;

        }
    }
}