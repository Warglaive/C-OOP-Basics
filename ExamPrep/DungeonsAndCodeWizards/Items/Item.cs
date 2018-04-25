using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;

namespace DungeonsAndCodeWizards.Items
{
    public abstract class Item : IItem
    {
        public int Weight { get; set; }

        public abstract void AffectCharacter(ICharacter character);

        protected Item(int weight)
        {
            this.Weight = weight;
        }
    }
}