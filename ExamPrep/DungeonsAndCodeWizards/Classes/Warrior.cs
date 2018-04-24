using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
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
            throw new System.NotImplementedException();
        }
    }
}