using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Inventories;

namespace DungeonsAndCodeWizards.Classes
{
    public class Warrior : Character, IAttackable
    {
        private const double baseHealth = 100;
        private const double baseArmor = 50;
        private const double abilityPoints = 40;
        private static readonly Bag bag = new Satchel();

        public Warrior(string name, Faction faction)
            : base(name, baseHealth, baseArmor, abilityPoints, bag, faction)
        {
        }

        public void Attack(Character character)
        {
            if (this.IsAlive && character.IsAlive)
            {
                //bug maybe
                if (this.Equals(character))
                {
                    Error.CannonAttackSelf();
                }
                if (this.Faction.Equals(character.Faction))
                {
                    Error.FriendlyFireError(this.Faction);
                }
                character.TakeDamage(this.AbilityPoints);
            }
            else
            {
                Error.MustBeAliveToPerformAction();
            }
        }
    }
}