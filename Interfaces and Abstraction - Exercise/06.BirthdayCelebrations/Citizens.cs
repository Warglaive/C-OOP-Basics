using System;
using System.Collections.Generic;
using System.Text;

public class Citizens : SocietyMembersId
{
    private string name;
    private string age;
    private string birthday;

    
    public Citizens(string name, string age, string id, string birthday)
        : base(id, birthday)
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