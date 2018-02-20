using System.Collections.Generic;


public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reverseTeam;

    public List<Person> FirstTeam
    {
        get => firstTeam;
    }
    public List<Person> ReverseTeam
    {
        get => reverseTeam;
    }

    public Team(string name)
    {
        this.firstTeam = new List<Person>();
        this.reverseTeam = new List<Person>();
        this.name = name;
    }

    public void AddPlayer(Person player)
    {
        if (player.Age < 40)
        {
            firstTeam.Add(player);
        }
        else
        {
            reverseTeam.Add(player);
        }
    }
}
