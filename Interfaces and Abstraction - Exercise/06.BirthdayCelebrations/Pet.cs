using System;
using System.Collections.Generic;
using System.Text;

public class Pet : SocietyMembersId
{
    private string name;
    private string birthday;

    public Pet(string name, string id, string birthday)
        : base(id, birthday)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

