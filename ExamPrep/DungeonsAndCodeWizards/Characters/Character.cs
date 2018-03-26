using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Bags;
using DungeonsAndCodeWizards.Characters.Enums;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Characters
{
    public abstract class Character
    {
        public ExceptionMessages ExceptionMessages = new ExceptionMessages();

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    ExceptionMessages.NullOrWhiteSpacException();
                }
                name = value;
            }
        }

        public double BaseHealth { get; set; }

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
                if (value < 0)
                {
                    value = 0;
                }
                health = value;
            }
        }

        public double BaseArmor { get; set; }
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
                if (value < 0)
                {
                    value = 0;
                }
                health = value;
                armor = value;
            }
        }

        public double AbilityPoints { get; set; }
        public Bag Bag { get; set; }
        public Faction Faction { get; set; }
        public bool IsAlive
        {
            get => true;
            set { throw new NotImplementedException(); }
        }

        public virtual double RestHealMultiplier => 0.2;

        public void TakeDamage(double hitPoints)
        {
            if (!this.IsAlive) //if dead
            {
                ExceptionMessages.MustBeAliveException();
            }

            this.Armor -= hitPoints;
            hitPoints -= hitPoints;

            if (this.Armor <= 0)
            {
                this.Health -= this.Armor;
                this.Armor = 0;

                if (this.Health <= 0)
                {
                    this.IsAlive = false;
                    this.Health = 0;
                }

                while (hitPoints > 0)
                {
                    this.Health -= hitPoints;
                    hitPoints -= hitPoints;

                    if (this.Health <= 0)
                    {
                        this.IsAlive = false;
                        this.Health = 0;
                    }
                }
            }
        }

        public void Rest()
        {
            if (!IsAlive)
            {
                ExceptionMessages.MustBeAliveException();
            }
            this.Health += this.BaseHealth * RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            if (!IsAlive)
            {
                ExceptionMessages.MustBeAliveException();
            }
            item.AffectCharacter(this);
        }


        public void UseItemOn(Item item, Character character)
        {
            if (!this.IsAlive || !character.IsAlive)
            {
                ExceptionMessages.MustBeAliveException();
            }
            item.AffectCharacter(character);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            if (!this.IsAlive || !character.IsAlive)
            {
                ExceptionMessages.MustBeAliveException();
            }
            character.ReceiveItem(item);
            this.Bag.Items.Remove(item);
        }

        public void ReceiveItem(Item item)
        {
            if (!IsAlive)
            {
                ExceptionMessages.MustBeAliveException();
            }
            this.Bag.Items.Add(item);
        }

        public Character(string name, double health, double armor
            , double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
        }
        //warrior ctor
        protected Character(string name, Faction faction)
        {
            this.Name = name;
            this.Faction = faction;
        }
    }
}