namespace DungeonsAndCodeWizards.Contracts
{
    public interface ICharacter
    {
        bool IsAlive { get; set; }
        double Health { get; set; }
    }
}