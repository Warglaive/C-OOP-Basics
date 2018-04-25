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
        public static void InvalidFaction(string faction)
        {
            throw new ArgumentException($"Invalid faction \"{faction}\"!");
        }
        public static void InvalidCharacterType(string characterType)
        {
            throw new ArgumentException($"Invalid character characterType \"{characterType}\"!");
        }
        public static void InvalidItemType(string itemName)
        {
            throw new ArgumentException($"Invalid item \"{itemName}\"!");
        }
        public static void CharacterNotFound(string charName)
        {
            throw new ArgumentException($"Character {charName} not found!");
        }
        public static void NoItemsInThePool()
        {
            throw new ArgumentException($"No items left in pool!");
        }
        public static void CannonAttack(string attackerName)
        {
            throw new ArgumentException($"{attackerName} cannot attack!");
        }
        public static void CannonHeal(string healerName)
        {
            throw new ArgumentException($"{healerName} cannot heal!");
        }
    }
}