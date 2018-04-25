using DungeonsAndCodeWizards.Characters;

namespace DungeonsAndCodeWizards.Contracts
{
    public interface IItem
    {
        int Weight { get; }
        void AffectCharacter(ICharacter character);
    }
}