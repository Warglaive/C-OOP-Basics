using System.Collections.Generic;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Contracts
{
    public interface IBag
    {
        int Capacity { get; set; }
        //The sum of the weights of the items in the bag.
        double Load { get; }
        IReadOnlyCollection<IItem> Items { get; }

        void AddItem(IItem item);
        IItem GetItem(string name);
    }
}