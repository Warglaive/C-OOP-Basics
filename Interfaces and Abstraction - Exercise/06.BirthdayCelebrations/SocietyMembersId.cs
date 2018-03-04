using System;
using System.Collections.Generic;
using System.Text;

public class SocietyMembersId
{
    public SocietyMembersId(string id, string birthDay)
    {
        this.Id = id;
        this.BirthDay = birthDay;
    }

    public string BirthDay { get; set; }
    public string Id { get; }

    public bool HasInvalidEnding(string lastDigits)
    {
        return this.BirthDay.EndsWith(lastDigits);
    }
}