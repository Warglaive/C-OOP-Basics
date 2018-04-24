using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Items;

namespace DungeonsAndCodeWizards.Contracts
{
    public interface ICharacter
    {
        string Name { get; }
        double BaseHealth { get; }
        double Health { get; set; }
        double BaseArmor { get; }
        double Armor { get; set; }
        double AbilityPoints { get; }
        IBag Bag { get; }
        Faction Faction { get; }
        bool IsAlive { get; set; }
        double RestHealMultiplier { get; }
        //behavior
        void TakeDamage(double hitPoints);
        void Rest();
        void UseItem(Item item);
        void UseItemOn(Item item, Character character);
        void GiveCharacterItem(Item item, Character character);
        void ReceiveItem(Item item);
    }
}