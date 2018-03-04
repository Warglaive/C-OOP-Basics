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
        set
        {
            if (value == "inProgress" || value == "Finished")
            {
                state = value;
            }
            //only mission skip
        }
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