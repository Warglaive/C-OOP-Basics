using System;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            try
            {
                ReadPlaylistLines();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static void ReadPlaylistLines()
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
        var validator = new Validator(artistName, songName, minutes, seconds);
    }
}