using System.Collections.Generic;


public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public List<Person> FirstTeam
    {
        get => firstTeam;
    }
    public List<Person> ReserveTeam
    {
        get => reserveTeam;
    }

    public Team(string name)
    {
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
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
            reserveTeam.Add(player);
        }
    }
}
