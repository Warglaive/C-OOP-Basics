using System;
using System.Collections.Generic;
using System.Text;

public class Team
{
    private int numberOfPlayers;
    private string teamName;
    private double teamRating;

    private Dictionary<string, int> TeamResult { get; set; }

    public Team()
    {
        this.TeamResult = new Dictionary<string, int>();
    }

    public Team(string teamName)
    {
        this.TeamName = teamName;
    }

    public double TeamRating
    {
        get { return teamRating; }
        set { teamRating = value; }
    }

    public string TeamName
    {
        get { return teamName; }
        set { teamName = value; }
    }

    public int NumberOfPlayers
    {
        get { return numberOfPlayers; }
        set { numberOfPlayers = value; }
    }
}