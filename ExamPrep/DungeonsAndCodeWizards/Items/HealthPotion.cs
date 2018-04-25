using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;

namespace DungeonsAndCodeWizards.Items
{
    public class HealthPotion : Item
    {
        private const int HealthRegen = 20;
        private const int weigth = 5;

        public HealthPotion()
            : base(weigth)
        {

        }

        public override void AffectCharacter(ICharacter character)
        {
            if (character.IsAlive)
            {
                character.Health += HealthRegen;
            }
            else
            {
                Error.MustBeAliveToPerformAction();
            }
        }
    }
}