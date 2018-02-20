using System;
using System.Collections.Generic;
using System.Linq;

public class Potato
{
    public static void Main()
    {
        string[] storage;
        Dictionary<string, Dictionary<string, long>> bag;
        long gold;
        long gems;
        long money;
        var input = ReadInput(out storage, out bag, out gold, out gems, out money);

        AddToStorage(storage, input, bag, gold, gems, money);

        Print(bag);
    }

    private static void AddToStorage(string[] storage, long input, Dictionary<string, Dictionary<string, long>> bag, long gold, long gems, long money)
    {
        for (var i = 0; i < storage.Length; i += 2)
        {
            var name = storage[i];
            var count = long.Parse(storage[i + 1]);

            var type = string.Empty;

            if (name.Length == 3)
            {
                type = "Cash";
            }
            else if (name.ToLower().EndsWith("gem"))
            {
                type = "Gem";
            }
            else if (name.ToLower() == "gold")
            {
                type = "Gold";
            }

            if (type == "")
            {
                continue;
            }
            if (input < bag.Values.Select(x => x.Values.Sum())
                    .Sum() + count)
            {
                continue;
            }

            if (type == "Gem")
            {
                if (!bag.ContainsKey(type))
                {
                    if (bag.ContainsKey("Gold"))
                    {
                        if (count > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (bag[type].Values.Sum() + count > bag["Gold"].Values.Sum())
                {
                    continue;
                }
            }
            else if (type == "Cash")
            {
                if (!bag.ContainsKey(type))
                {
                    if (bag.ContainsKey("Gem"))
                    {
                        if (count > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (bag[type].Values.Sum() + count > bag["Gem"].Values.Sum())
                {
                    continue;
                }
            }

            if (!bag.ContainsKey(type))
            {
                bag[type] = new Dictionary<string, long>();
            }

            if (!bag[type].ContainsKey(name))
            {
                bag[type][name] = 0;
            }

            bag[type][name] += count;
            switch (type)
            {
                case "Gold":
                    gold += count;
                    break;
                case "Gem":
                    gems += count;
                    break;
                case "Cash":
                    money += count;
                    break;
            }
        }
    }

    private static long ReadInput(out string[] storage, out Dictionary<string, Dictionary<string, long>> bag, out long gold, out long gems, out long money)
    {
        var input = long.Parse(Console.ReadLine());
        storage = Console.ReadLine()
            .Split(new[] {' '}
                , StringSplitOptions.RemoveEmptyEntries);

        bag = new Dictionary<string, Dictionary<string, long>>();
        gold = 0L;
        gems = 0L;
        money = 0L;
        return input;
    }

    private static void Print(Dictionary<string, Dictionary<string, long>> bag)
    {
        foreach (var currentItem in bag)
        {
            Console.WriteLine($"<{currentItem.Key}> ${currentItem.Value.Values.Sum()}");
            foreach (var item2 in currentItem.Value.OrderByDescending(y => y.Key)
                .ThenBy(y => y.Value))
            {
                Console.WriteLine($"##{item2.Key} - {item2.Value}");
            }
        }
    }
}