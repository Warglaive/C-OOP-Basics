using System;
using System.Collections.Generic;
using System.Text;


public class Animal
{
    private string Name { get; }
    private string FavoriteFood { get; }

    protected Animal(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }


    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
    }
}