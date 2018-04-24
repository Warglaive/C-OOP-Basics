using System;
using DungeonsAndCodeWizards.Characters;

namespace DungeonsAndCodeWizards.Exceptions
{
    public static class Error
    {
        public static void MustBeAliveToPerformAction()
        {
            throw new InvalidOperationException("Must be alive to perform this action!");
        }
        public static void BagIsFull()
        {
            throw new InvalidOperationException("Bag is full!");
        }
        public static void BagIsEmpty()
        {
            throw new InvalidOperationException("Bag is empty!");
        }
        public static void NoItemWithThatName(string name)
        {
            throw new ArgumentException($"No item with name {name} in bag!");
        }
        public static void NameCannonBeNullOrWhiteSpace()
        {
            throw new ArgumentException("Name cannot be null or whitespace!");
        }
        public static void CannonAttackSelf()
        {
            throw new InvalidOperationException("Cannot attack self!");
        }
        public static void FriendlyFireError(Faction faction)
        {
            var factionName = faction.ToString();
            throw new ArgumentException($"Friendly fire! Both characters are from {factionName} faction!");
        }
        public static void CannonHealEnemy()
        {
            throw new InvalidOperationException($"Cannot heal enemy character!");
        }
    }
}