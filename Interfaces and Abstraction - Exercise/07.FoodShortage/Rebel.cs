using System;
using System.Collections.Generic;
using System.Text;


class Rebel : SocietyMembersId, IBuyer
{
    private string name;
    private int age;
    private string group;

    public Rebel(string name, int age, string id, string birthday, string group, int food)
        : base(name,id, birthday)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
        this.Food = food;
    }

    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string BuyFood()
    {
        throw new NotImplementedException();
    }

    public int Food { get; }
}

