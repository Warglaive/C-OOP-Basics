using System;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Characters
{
    public abstract class Character : ICharacter
    {
        private const int MinHealth = 0;
        private const int MinArmor = 0;
        private const double RestMultiplierDefault = 0.2;

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Error.NameCannonBeNullOrWhiteSpace();
                }
                name = value;
            }
        }

        public double BaseHealth { get; }
        private double health;

        public double Health
        {
            get { return health; }
            set
            {
                if (value > this.BaseHealth)
                {
                    value = this.BaseHealth;
                }
                if (value < MinHealth)
                {
                    value = MinHealth;
                }
                health = value;
            }
        }

        public double BaseArmor { get; }
        private double armor;

        public double Armor
        {
            get { return armor; }
            set
            {
                if (value > this.BaseArmor)
                {
                    value = this.BaseArmor;
                }
                if (value < MinArmor)
                {
                    value = MinArmor;
                }
                armor = value;
            }
        }

        public double AbilityPoints { get; }
        public IBag Bag { get; }
        public Faction Faction { get; }
        public bool IsAlive { get; set; } = true;

        public virtual double RestHealMultiplier => RestMultiplierDefault;

        public void TakeDamage(double hitPoints)
        {
            if (this.IsAlive)
            {
                //careful
                this.Armor -= hitPoints;
                //hitPoints -= hitPoints;
                if (this.Armor < 0)
                {
                    this.Health -= Math.Abs(this.Armor);
                }
                if (this.Health <= 0)
                {
                    this.IsAlive = false;
                }
            }
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