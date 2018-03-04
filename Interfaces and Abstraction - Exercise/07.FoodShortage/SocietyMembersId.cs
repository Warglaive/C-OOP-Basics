using System;
using System.Collections.Generic;
using System.Text;

public class SocietyMembersId : IBuyer
{
    public SocietyMembersId(string name, string id, string birthDay)
    {
        this.Name = name;
        this.Id = id;
        this.BirthDay = birthDay;
    }
    public string Name { get; }
    public string BirthDay { get; }
    public string Id { get; }

    public bool HasInvalidEnding(string lastDigits)
    {
        return this.BirthDay.EndsWith(lastDigits);
    }

    public int BuyFood(string name)
    {
        return this.Food += 5;
    }

    public int Food { get; set; }
}