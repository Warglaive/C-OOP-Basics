using DungeonsAndCodeWizards.Inventories;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Entities
{
    public class Engine
    {
        public void Run()
        {
            var test = new Satchel();
            var type = test.GetType();
        }
    }
}
