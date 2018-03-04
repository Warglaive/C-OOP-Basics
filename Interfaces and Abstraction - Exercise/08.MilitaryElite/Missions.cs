using System;
using System.Collections.Generic;
using System.Text;


public class Missions
{
    private string codeName;
    private string state;

    public string State
    {
        get { return state; }
        set { state = value; }
    }


    public string CodeName
    {
        get { return codeName; }
        set { codeName = value; }
    }

    public string CompleteMission(string command)
    {
        //
        return command;
    }
}