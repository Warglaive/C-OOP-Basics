using DungeonsAndCodeWizards.Contracts;

namespace DungeonsAndCodeWizards.Characters
{
    public abstract class Character : ICharacter
    {
        public bool IsAlive { get; set; }
        public double Health { get; set; }
    }
}