using System;
using System.Collections.Generic;
using System.Text;


public class Missions
{
    private string codeName;
    private string state;

    public Missions(string codeName, string state)
    {
        this.State = state;
        this.CodeName = codeName;
    }

    public string State
    {
        get { return state; }
        set
        {
            if (value == "inProgress" || value == "Finished")
            {
                state = value;
            }
        }
    }


    public string CodeName
    {
        get { return codeName; }
        set
        {
            if (this.State == "inProgress" || this.State == "Finished")
            {
                codeName = value;
            }
        }
    }

    public string CompleteMission(string command)
    {
        //
        this.State = "Finished";
        return command;
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"  Code Name: {this.CodeName} State: {this.State}");
        return sb.ToString().TrimEnd();
    }
}