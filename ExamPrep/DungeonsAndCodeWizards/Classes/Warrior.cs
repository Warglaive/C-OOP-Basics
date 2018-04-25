using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
using DungeonsAndCodeWizards.Inventories;

namespace DungeonsAndCodeWizards.Classes
{
    public class Warrior : Character, IAttackable
    {
        private double warriorBaseHealth = 100d;
        private double warriorBaseArmor = 50d;
        public Warrior(string name, Faction faction)
            : base(name, 100, 50, 40, new Satchel(), faction)
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

        public override double BaseHealth => this.warriorBaseHealth;
        public override double BaseArmor => this.warriorBaseArmor;
    }
}