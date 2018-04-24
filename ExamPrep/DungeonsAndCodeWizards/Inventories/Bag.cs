using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Inventories
{
    public abstract class Bag : IBag
    {
        private const int DefaultCapacity = 100;

        public int Capacity { get; set; }
        public double Load => this.Items.Sum(i => i.Weight);

        public IReadOnlyCollection<Item> Items => this.AddedItems;

        private List<Item> AddedItems;

        public void AddItem(Item item)
        {

            var currentLoad = this.Items.Sum(i => i.Weight) + item.Weight;
            if (currentLoad > this.Capacity)
            {
                Error.BagIsFull();
            }
            else
            {
                AddedItems.Add(item);
            }
        }

        public Item GetItem(string name)
        {
            //need refactor
            if (this.Items.Count == 0)
            {
                Error.BagIsEmpty();
            }

            var type = Assembly.GetCallingAssembly().GetType(name);
            var itemName = (Item)Activator.CreateInstance(type);

            if (name != itemName.ToString())
            {
                Error.NoItemWithThatName(name);
            }
            this.AddedItems.Remove(itemName);
            return itemName;
        }
        //bullshit
        protected Bag(int capacity = DefaultCapacity)
        {
            this.AddedItems = new List<Item>();
            this.Capacity = capacity;
        }
    }
}