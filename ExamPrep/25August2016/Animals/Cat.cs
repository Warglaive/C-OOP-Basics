using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cat : Animal
{
    public int IQ { get; set; }

    public Cat(string name, int age)
        : base(name, age)
    {
    }
}