public class Pokemon
{
    private string name;
    private string element;
    private decimal health;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Element
    {
        get => element;
        set => element = value;
    }

    public decimal Health
    {
        get => health;
        set => health = value;
    }
}
