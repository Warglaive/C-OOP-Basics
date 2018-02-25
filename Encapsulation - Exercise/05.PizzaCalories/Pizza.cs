using System;
using System.Collections.Generic;
using System.Linq;


public class Pizza
{
    private const int NameMinLenght = 1;
    private const int NameMaxLenght = 15;
    private const int MinToppings = 0;
    private const int MaxToppings = 10;
    private string name;

    public Pizza()
    {
        this.Toppings = new List<Topping>();
    }

    public Pizza(string name)
        : this()
    {
        Name = name;
    }

    private decimal ToppingsCalories
    {
        get
        {
            if (this.Toppings.Count == 0)
            {
                return 0;
            }
            return this.Toppings.Select(t => t.calories).Sum();
        }
    }

    private decimal Calories => this.Dought.Calories + this.ToppingsCalories;

    private string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > NameMaxLenght || value.Length < NameMinLenght)
            {
                throw new ArgumentException($"Pizza name should be between {NameMinLenght} and {NameMaxLenght} symbols.");
            }
            name = value;
        }
    }

    private Dough Dought { get; set; }
    private List<Topping> Toppings { get; set; }

    public void SetDought(Dough dough)
    {
        if (this.Dought != null)
        {
            throw new InvalidOperationException("Dought already set!");
        }
        this.Dought = dough;
    }

    public void addTopping(Topping topping)
    {
        this.Toppings.Add(topping);
        if (this.Toppings.Count < MinToppings || this.Toppings.Count > MaxToppings)
        {
            throw new ArgumentException($"Number of toppings should be in range [{MinToppings}..{MaxToppings}].");
        }
    }

    public override string ToString()
    {
        return $"{this.Name} - {Calories:f2} Calories.";
    }
}