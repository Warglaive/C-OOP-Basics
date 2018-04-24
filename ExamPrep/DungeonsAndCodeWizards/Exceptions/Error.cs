using System;

namespace DungeonsAndCodeWizards.Exceptions
{
    public static class Error
    {
        public static Exception MustBeAliveToPerformAction()
        {
            throw new InvalidOperationException("Must be alive to perform this action!");
        }
        public static Exception BagIsFull()
        {
            throw new InvalidOperationException("Bag is full!");
        }
        public static Exception BagIsEmpty()
        {
            throw new InvalidOperationException("Bag is empty!");
        }
        public static Exception NoItemWithThatName(string name)
        {
            throw new ArgumentException($"No item with name {name} in bag!");
        }
        public static Exception NameCannonBeNullOrWhiteSpace()
        {
            throw new ArgumentException("Name cannot be null or whitespace!");
        }
    }
}