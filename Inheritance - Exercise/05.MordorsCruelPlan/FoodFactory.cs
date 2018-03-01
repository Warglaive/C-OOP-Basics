using System;
using System.Collections.Generic;
using System.Text;


public class FoodFactory
{
    public string[] ReadFood()
    {
        var input = Console.ReadLine().Split(new[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
        return input;
    }
}