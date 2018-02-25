using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var pizzaName = Console.ReadLine().Split()[1];
        var pizza = new Pizza(pizzaName);
        var doughtInput = Console.ReadLine().Split();
        var flourType = doughtInput[1];
        var bakingTechnique = doughtInput[2];
        var doughtWeight = decimal.Parse(doughtInput[3]);

        var dought = new Dough(flourType, bakingTechnique, doughtWeight);
        pizza.SetDought(dought);

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            var toppingInput = command.Split();
            var toppingType = toppingInput[1];
            var toppingWeight = decimal.Parse(toppingInput[2]);
            var topping = new Topping(toppingType, toppingWeight);
            pizza.addTopping(topping);
        }
        Console.WriteLine(pizza.ToString());
    }
}