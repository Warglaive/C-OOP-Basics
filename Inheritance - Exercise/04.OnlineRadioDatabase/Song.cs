using System;
using System.Collections.Generic;
using System.Text;


public class Song
{
    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;
    private Dictionary<string, Dictionary<string, TimeSpan>> result;


    public Song(string artistName, string songName
        , TimeSpan totalLength)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
        //SAVE SONGS

        result = new Dictionary<string, Dictionary<string, TimeSpan>>();
        this.Result = result;
        if (!result.ContainsKey(this.ArtistName))//test
        {
            result.Add(ArtistName, new Dictionary<string, TimeSpan>());
        }
        if (!result[ArtistName].ContainsKey(SongName))
        {
            result[ArtistName].Add(SongName, new TimeSpan());
        }
        result[ArtistName][SongName]=totalLength;
        Console.WriteLine("Song added.");
    }

    public Dictionary<string, Dictionary<string, TimeSpan>> Result
    {
        get { return result; }
        set { result = value; }
    }

    private string ArtistName
    {
        get { return artistName; }
        set { artistName = value; }
    }

    private string SongName
    {
        get { return songName; }
        set { songName = value; }
    }

    private int Minutes
    {
        get { return minutes; }
        set { minutes = value; }
    }

    private int Seconds
    {
        get { return seconds; }
        set { seconds = value; }
    }
}