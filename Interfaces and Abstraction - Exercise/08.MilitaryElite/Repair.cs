using System;
using System.Collections.Generic;
using System.Text;


public class Repair
{
    private string partName;
    private int hoursWorked;

    public Repair(string partName, int hoursWorked)
    {
        this.PartName = partName;
        this.HoursWorked = hoursWorked;
    }
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

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"  Part Name: {this.PartName} Hours Worked: {this.HoursWorked}");
        return sb.ToString();
    }
}