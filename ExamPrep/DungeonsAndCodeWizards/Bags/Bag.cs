using System.Collections.Generic;
using System.Linq;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Bags
{
    public abstract class Bag
    {
        public ExceptionMessages ExceptionMessages = new ExceptionMessages();

        public Bag(int capacity)
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; }
        public int Load => Items.Sum(x => x.Weight);
        public List<Item> Items { get; } //read-only


        public void AddItem(Item item)
        {
            if (Load + item.Weight > this.Capacity)
            {
                ExceptionMessages.BagIsFullException();
            }
            Items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (!Items.Any()) //if empty bag
            {
                ExceptionMessages.BagIsEmpty();
            }

            var itemInBag = Items
                .FirstOrDefault(i => i.GetType().Name == name);

            if (itemInBag == null)
            {
                ExceptionMessages.ItemDosentExist(name);
            }
            Items.Remove(itemInBag);
            return itemInBag;
        }
    }
}