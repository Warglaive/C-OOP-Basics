using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var playList = new List<Song>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            try
            {
                ReadPlaylistLines(playList);
                Console.WriteLine($"Songs added: {playList.Count}");
                //

                //
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static void ReadPlaylistLines(List<Song> playList)
    {
        var songParts = Console.ReadLine()
            .Trim()
            .Split(';')
            .ToList();
        var artistName = songParts[0];
        var songName = songParts[1];
        var timeParts = songParts[2].Split(':');
        var minutes = int.Parse(timeParts[0]);
        var seconds = int.Parse(timeParts[1]);
        var minToSecs = minutes * 60;

        var totalLengthInt = minToSecs + seconds;
        var totalLength = TimeSpan.FromSeconds(totalLengthInt);

        var validator = new Validator(artistName, songName, minutes, seconds);

        var song = new Song(artistName, songName, minutes, seconds);
        playList.Add(song);
    }
}