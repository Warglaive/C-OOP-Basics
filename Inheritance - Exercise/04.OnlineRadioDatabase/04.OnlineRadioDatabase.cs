using System;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var songParts = Console.ReadLine()
                .Trim()
                .Split(';')
                .ToList();
            var artistName = songParts[0];
            var songName = songParts[1];
            var minutes = int.Parse(songParts[2]);
            var seconds = int.Parse(songParts[3]);

            var song = new Song(artistName, songName, minutes, seconds);
        }
    }
}