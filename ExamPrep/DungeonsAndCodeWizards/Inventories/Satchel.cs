namespace DungeonsAndCodeWizards.Inventories
{
    public class Satchel : Bag
    {
        private const int capacity = 20;

        protected Satchel()
            : base(capacity)
        {
        }
    }
}