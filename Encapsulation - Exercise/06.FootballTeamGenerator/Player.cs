using System;
using System.Collections.Generic;
using System.Text;


public class Player
{
    private string name;
    private List<int> averageStats;

    public Player()
    {
        this.AverageStats = new List<int>();
    }

    public Player(string name) : this()
    {
        this.Name = name;
    }

    public List<int> AverageStats
    {
        get { return averageStats; }
        set { averageStats = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}