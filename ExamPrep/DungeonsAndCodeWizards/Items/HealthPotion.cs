using DungeonsAndCodeWizards.Characters;

namespace DungeonsAndCodeWizards.Items
{
    public class HealthPotion : Item
    {
        public HealthPotion()
            : base(5)
        {
        }

        public override void AffectCharacter(Character character)
        {
            character.Health += 20;
        }
    }
}