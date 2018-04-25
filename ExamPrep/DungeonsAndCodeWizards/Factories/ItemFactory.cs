using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Factories
{
    public class ItemFactory
    {
        public Item CreateItem(string name)
        {
            Item currentItem = null;
            switch (name)
            {
                case "ArmorRepairKit":
                    currentItem = new ArmorRepairKit();
                    break;
                case "HealthPotion":
                    currentItem = new HealthPotion();
                    break;
                case "PoisonPotion":
                    currentItem = new PoisonPotion();
                    break;
                default:
                    Error.InvalidItemType(name);
                    break;
            }
            return currentItem;
        }
    }
}