using System;
using System.Collections.Generic;
using System.Text;

public class SocietyMembersId
{
    public SocietyMembersId(string id)
    {
        this.Id = id;
    }

    public string Id { get; set; }

    public bool HasInvalidEnding(string lastDigits)
    {
        return this.Id.EndsWith(lastDigits);
    }
}