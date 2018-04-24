using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Characters
{
    public abstract class Character : ICharacter
    {
        public string Name { get; }
        public double BaseHealth { get; }
        public double Health { get; set; }
        public double BaseArmor { get; }
        public double Armor { get; set; }
        public double AbilityPoints { get; }
        public IBag Bag { get; }
        public Faction Faction { get; }
        public bool IsAlive { get; set; }
        public double RestHealMultiplier { get; }
        public void TakeDamage(double hitPoints)
        {
            throw new System.NotImplementedException();
        }

        public void Rest()
        {
            throw new System.NotImplementedException();
        }

        public void UseItem(Item item)
        {
            throw new System.NotImplementedException();
        }

        public void UseItemOn(Item item, Character character)
        {
            throw new System.NotImplementedException();
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            throw new System.NotImplementedException();
        }

        public void ReceiveItem(Item item)
        {
            throw new System.NotImplementedException();
        }
    }
}