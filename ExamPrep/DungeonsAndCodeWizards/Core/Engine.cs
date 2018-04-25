using System;
using System.Linq;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        private string getStats;
        private DungeonMaster DungeonMaster;
        public void Run()
        {
            try
            {
                GiveInputToDungeonMaster();
            }
            catch (Exception e)
            {
                if (e is ArgumentException argument)
                {
                    Console.WriteLine($"Parameter Error: {argument.Message}");
                }
                if (e is InvalidOperationException operationArgument)
                {
                    Console.WriteLine($"Invalid Operation: {operationArgument.Message}");
                }
            }
        }

        private void GiveInputToDungeonMaster()
        {
            var input = Console.ReadLine();
            while (!this.DungeonMaster.IsGameOver()
                || string.IsNullOrEmpty(input))
            {
                var commands = input.Split();
                var command = commands[0];
                var args = commands.Skip(1).ToArray();
                switch (command)
                {
                    case "JoinParty":
                        Console.WriteLine(this.DungeonMaster.JoinParty(args));
                        break;
                    case "AddItemToPool":
                        Console.WriteLine(this.DungeonMaster.AddItemToPool(args));
                        break;
                    case "PickUpItem":
                        Console.WriteLine(this.DungeonMaster.PickUpItem(args));
                        break;
                    case "UseItem":
                        Console.WriteLine(this.DungeonMaster.UseItem(args));
                        break;
                    case "UseItemOn":
                        Console.WriteLine(this.DungeonMaster.UseItemOn(args));
                        break;
                    case "GiveCharacterItem":
                        Console.WriteLine(this.DungeonMaster.GiveCharacterItem(args));
                        break;
                    case "GetStats":
                        getStats = this.DungeonMaster.GetStats();
                        break;
                    case "Attack":
                        Console.WriteLine(this.DungeonMaster.Attack(args));
                        break;
                    case "Heal":
                        Console.WriteLine(this.DungeonMaster.Heal(args));
                        break;
                    case "EndTurn":
                        Console.WriteLine(this.DungeonMaster.EndTurn());
                        break;
                    case "IsGameOver":
                        Console.WriteLine(this.DungeonMaster.IsGameOver());
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Final stats:");
            Console.WriteLine(getStats);
        }

        public Engine()
        {
            this.DungeonMaster = new DungeonMaster();
        }
    }
}