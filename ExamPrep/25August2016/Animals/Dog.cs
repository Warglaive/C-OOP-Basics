using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dog : Animal
{
    public int LearnedCommands { get; set; }

    public Dog(string name, int age) 
        : base(name, age)
    {
    }
}