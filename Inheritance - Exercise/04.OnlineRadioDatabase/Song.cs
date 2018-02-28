using System;
using System.Collections.Generic;
using System.Text;


public class Song
{
    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;

    public Song(string artistName, string songName
        , int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
        //
        var validator = new Validator(ArtistName, SongName, Minutes, Seconds);

    }
    public string ArtistName
    {
        get { return artistName; }
        set { artistName = value; }
    }

    public string SongName
    {
        get { return songName; }
        set { songName = value; }
    }

    public int Minutes
    {
        get { return minutes; }
        set { minutes = value; }
    }

    public int Seconds
    {
        get { return seconds; }
        set { seconds = value; }
    }
}