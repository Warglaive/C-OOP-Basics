using System;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        public DungeonMaster DungeonMaster;
        public void Run()
        {
            try
            {
                var input = Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Engine()
        {
            this.DungeonMaster = new DungeonMaster();
        }
    }
}