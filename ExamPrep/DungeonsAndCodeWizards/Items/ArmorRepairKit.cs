using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;

namespace DungeonsAndCodeWizards.Items
{
    public class ArmorRepairKit : Item
    {
        private const int weight = 10;

        public ArmorRepairKit()
            : base(weight)
        {
        }

        public override void AffectCharacter(ICharacter character)
        {
            if (character.IsAlive)
            {
                character.Armor = character.BaseArmor;
            }
            else
            {
                Error.MustBeAliveToPerformAction();
            }
        }
    }
}
