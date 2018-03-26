using DungeonsAndCodeWizards.Bags;
using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Characters.Enums;
using DungeonsAndCodeWizards.Interfaces;

namespace DungeonsAndCodeWizards.WarriorTypes
{
    public class Warrior : Character, IAttackable
    {
        public void Attack(Character character)
        {

        }

        public Warrior(string name,Faction faction)
            : base(name,  faction)
        {
            this.BaseHealth = 100;
            this.BaseArmor = 50;
            this.AbilityPoints = 40;
            this.Bag = new Satchel();
        }
    }
}