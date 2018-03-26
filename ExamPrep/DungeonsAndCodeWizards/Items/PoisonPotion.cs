using DungeonsAndCodeWizards.Characters;

namespace DungeonsAndCodeWizards.Items
{
    public class PoisonPotion : Item
    {
        public PoisonPotion()
            : base(5)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                ExceptionMessages.MustBeAliveException();
            }

            character.Health -= 20;
            if (character.Health <= 0)
            {
                character.IsAlive = false;
            }
        }
    }
}
