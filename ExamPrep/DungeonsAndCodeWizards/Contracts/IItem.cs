using DungeonsAndCodeWizards.Characters;

namespace DungeonsAndCodeWizards.Contracts
{
    public interface IItem
    {
        int Weigth { get; }
        void AffectCharacter(Character character);
    }
}