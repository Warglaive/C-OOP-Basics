using System.Text;
class Car
{
    private const string offset = "  ";
    public string model;
    private Engine engine;
    private int weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        weight = -1;
        color = "n/a";
    }

    public Car(string model, Engine engine, int weight)
    {
        this.model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = "n/a";
    }

    public Car(string model, Engine engine, string color)
    {
        this.model = model;
        this.engine = engine;
        weight = -1;
        this.color = color;
    }
    public Car(string model, Engine engine, int weight, string color)
    {
        this.model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = color;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}:\n", model);
        sb.Append(engine);
        sb.AppendFormat("{0}Weight: {1}\n", offset, weight == -1 
            ? "n/a" : weight.ToString());
        sb.AppendFormat("{0}Color: {1}", offset, color);
        return sb.ToString();
    }
}

