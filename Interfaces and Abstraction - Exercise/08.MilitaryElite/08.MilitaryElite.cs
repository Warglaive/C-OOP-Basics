using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var setOfPrivates = new List<Private>();
        while (input != "End")
        {
            var inputArgs = input.Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries);

            var soldierType = inputArgs[0];

            switch (soldierType)
            {
                case "Private":
                    var currentPrivate = ReadPrivate(inputArgs);
                    setOfPrivates.Add(currentPrivate);
                    Console.WriteLine(currentPrivate);
                    break;
                case "LeutenantGeneral":
                    var currentLeutenantGeneral = ReadLeutenantGeneral(inputArgs, setOfPrivates);
                    Console.WriteLine(currentLeutenantGeneral);
                    break;
                case "Engineer":
                    var currentEngineer = ReadEngineer(inputArgs);
                    break;
            }
            input = Console.ReadLine();
        }
    }

    private static object ReadEngineer(string[] inputArgs)
    {
        var 
    }

    private static LeutenantGeneral ReadLeutenantGeneral(string[] inputArgs, List<Private> setOfPrivates)
    {
        var privatesIDs = new List<string>();

        var id = inputArgs[1];
        var firstName = inputArgs[2];
        var lastName = inputArgs[3];
        var salary = double.Parse(inputArgs[4]);

        for (int i = 5; i <= inputArgs.Length - 1; i++)
        {
            privatesIDs.Add(inputArgs[i]);
        }
        // bug maybe 
        var privatesToAdd = new List<Private>();
        var temp = new List<Private>();
        foreach (var currentId in privatesIDs)
        {
            temp = setOfPrivates
               .Where(p => p.Id == currentId)
               .ToList();
            privatesToAdd.Add(temp[0]);
            temp.Clear();
        }

        var currentLeutenantGeneral = new LeutenantGeneral(privatesToAdd, id, firstName, lastName, salary);
        return currentLeutenantGeneral;
    }

    private static Private ReadPrivate(string[] inputArgs)
    {
        var id = inputArgs[1];
        var firstName = inputArgs[2];
        var lastName = inputArgs[3];
        var salary = double.Parse(inputArgs[4]);
        var currentPrivate = new Private(id, firstName, lastName, salary);
        return currentPrivate;
    }
}