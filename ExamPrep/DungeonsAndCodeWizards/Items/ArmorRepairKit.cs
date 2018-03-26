using DungeonsAndCodeWizards.Characters;

namespace DungeonsAndCodeWizards.Items
{
    public class ArmorRepairKit : Item
    {
        public ArmorRepairKit()
            : base(10)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if (character.IsAlive)
            {
                character.Armor = character.BaseArmor;
            }
            else
            {
                ExceptionMessages.MustBeAliveException();
            }
        }
    }
}