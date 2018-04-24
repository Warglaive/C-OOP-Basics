using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Inventories;

namespace DungeonsAndCodeWizards.Classes
{
    public class Cleric : Character, IHealable
    {
        private const double baseHealth = 50;
        private const double baseArmor = 25;
        private const double abilityPoints = 40;
        private static readonly Bag bag = new Backpack();

        public Cleric(string name, Faction faction)
            : base(name, baseHealth, baseArmor, abilityPoints, bag, faction)
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
    }
}