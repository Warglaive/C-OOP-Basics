using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Inventories;

namespace DungeonsAndCodeWizards.Classes
{
    public class Cleric : Character, IHealable
    {
        private double clericBaseHealth = 50d;
        private double clericBaseArmor = 25d;
        public Cleric(string name, Faction faction)
            : base(name, 50, 25, 40, new Backpack(), faction)
        {
        }

        public void Heal(Character character)
        {
            if (this.IsAlive && character.IsAlive)
            {
                if (!this.Faction.Equals(character.Faction))
                {
                    Error.CannonHealEnemy();
                }
                character.Health += this.AbilityPoints;
            }
        }

        public override double BaseHealth => this.clericBaseHealth;
        public override double BaseArmor => this.clericBaseArmor;
    }
}