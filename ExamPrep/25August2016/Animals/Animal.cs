using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Animal
{
    private string Name { get; set; }
    private int Age { get; set; }
    private bool cleansingStatus;
    public bool CleansingStatus
    {
        get => false;
        set { cleansingStatus = value; }
    }

    protected Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}