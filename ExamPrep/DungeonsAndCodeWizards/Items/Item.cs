using System;
using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Exceptions;

namespace DungeonsAndCodeWizards.Items
{
    public abstract class Item
    {
        public ExceptionMessages ExceptionMessages = new ExceptionMessages();

        public int Weight { get; }

        public abstract void AffectCharacter(Character character);

        protected Item(int weight)
        {
            this.Weight = weight;
        }
    }
}
