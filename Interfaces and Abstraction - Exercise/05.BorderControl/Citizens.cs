using System;
using System.Collections.Generic;
using System.Text;

public class Citizens : SocietyMembersId
{
    private string name;
    private string age;

    public Citizens(string name, string age, string id) 
        : base(id)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Age
    {
        get { return age; }
        set { age = value; }
    }


}