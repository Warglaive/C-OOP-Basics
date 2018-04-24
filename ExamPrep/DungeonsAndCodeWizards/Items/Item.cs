using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Exceptions;
namespace DungeonsAndCodeWizards.Items
{
    public abstract class Item : IItem
    {
        public int Weigth { get; }

        public abstract void AffectCharacter(Character character);

        protected Item(int weight)
        {
            this.Weigth = weight;
        }
    }
}