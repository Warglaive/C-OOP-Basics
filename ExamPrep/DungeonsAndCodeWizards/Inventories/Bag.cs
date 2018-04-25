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

        public IReadOnlyCollection<IItem> Items => this.AddedItems;

        private List<IItem> AddedItems;

        public void AddItem(IItem item)
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

        public IItem GetItem(string name)
        {
            if (!this.Items.Any())
            {
                Error.BagIsEmpty();
            }
            //possible bug
            var itemName = this.Items
                .First(i => i.GetType().Name == name);

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
            this.AddedItems = new List<IItem>();
            this.Capacity = capacity;
        }
    }
}