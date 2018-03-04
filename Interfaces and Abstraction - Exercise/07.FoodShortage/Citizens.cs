using System;
using System.Collections.Generic;
using System.Text;

public class Citizens : SocietyMembersId, IBuyer
{
    private string name;
    private int age;


    public Citizens(string name, int age, string id, string birthday, int food)
        : base(name ,id, birthday)
    {
        this.Age = age;
        this.Food = food;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string BuyFood()
    {
        throw new NotImplementedException();
    }

    public int Food { get; }
}