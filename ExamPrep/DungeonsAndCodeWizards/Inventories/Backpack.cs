namespace DungeonsAndCodeWizards.Inventories
{
    public class Backpack : Bag
    {
        private const int capacity = 100;
        protected Backpack()
            : base(capacity)
        {
        }
    }
}
