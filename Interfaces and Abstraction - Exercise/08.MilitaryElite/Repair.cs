using System;
using System.Collections.Generic;
using System.Text;


public class Repair
{
    private string partName;
    private int hoursWorked;

    public int HoursWorked
    {
        get { return hoursWorked; }
        set { hoursWorked = value; }
    }

    public string PartName
    {
        get { return partName; }
        set { partName = value; }
    }
}