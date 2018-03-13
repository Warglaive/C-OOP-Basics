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
        double totalEnergy = 0;
        double totalOre = 0;
        while (inputCommands[0] != "Shutdown")
        {
            var command = inputCommands[0];
            //NOTE: DraftManager class methods are called from the outside so these methods must NOT receive the command parameter as part of the arguments!
            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(inputCommands));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(inputCommands));
                    break;
                case "Day":
                    var providedEnergy = draftManager
                        .providers.Sum(x => x.EnergyOutput);
                    var requiredEnergy = draftManager.harvesters
                        .Sum(h => h.EnergyRequirement);

                    totalEnergy += providedEnergy;
                    //Mode check
                    if (draftManager.mode == "Half")
                    {
                        //consume energy 60%
                        if (totalEnergy >= requiredEnergy)
                        {
                            totalOre += draftManager
                                .harvesters.Sum(x => x.OreOutput) * 0.50;
                            //consume energy 60%
                            totalEnergy = totalEnergy - requiredEnergy * 0.60;

                            Console.WriteLine(draftManager.Day(draftManager
                                .harvesters.Sum(x => x.OreOutput), providedEnergy));
                        }
                        else
                        {
                            Console.WriteLine(draftManager.Day(totalOre, providedEnergy));
                        }
                    }
                    else if (draftManager.mode == "Full")
                    {
                        if (totalEnergy >= requiredEnergy)
                        {
                            totalOre += draftManager
                                .harvesters.Sum(x => x.OreOutput);
                            //consume energy
                            totalEnergy -= requiredEnergy;

                            Console.WriteLine(draftManager.Day(draftManager
                                .harvesters.Sum(x => x.OreOutput), providedEnergy));
                        }
                        else
                        {
                            Console.WriteLine(draftManager.Day(totalOre, providedEnergy));
                        }
                    }

                    else if (draftManager.mode == "Energy")
                    {
                        //Consume nothing, produce nothing
                        Console.WriteLine(draftManager.Day(totalOre, providedEnergy));
                    }
                    //
                    break;
                case "Mode":
                    draftManager.Mode(inputCommands);
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(inputCommands));
                    break;
            }
            inputCommands = Console.ReadLine()
                .Split().ToList();
        }
        Console.Write(draftManager.ShutDown());
        Console.WriteLine($"Total Energy Stored: {totalEnergy}");
        Console.WriteLine($"Total Mined Plumbus Ore: {totalOre}");
    }
}