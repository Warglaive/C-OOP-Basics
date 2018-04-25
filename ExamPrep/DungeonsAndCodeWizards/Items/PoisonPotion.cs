using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
namespace DungeonsAndCodeWizards.Items
{
    public class PoisonPotion : Item
    {
        private const int HealthDecrease = 20;
        private const int weight = 5;

        public PoisonPotion()
            : base(weight)
        {

        }

        public override void AffectCharacter(ICharacter character)
        {
            if (character.IsAlive)
            {
                character.Health -= HealthDecrease;
                if (character.Health <= 0)
                {
                    character.IsAlive = false;
                }
            }
            else
            {
                Error.MustBeAliveToPerformAction();
            }
        }
    }
}
