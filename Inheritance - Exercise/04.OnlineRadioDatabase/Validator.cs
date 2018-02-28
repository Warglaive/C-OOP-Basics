using System;


public class Validator
{
    public Validator(string artistName, string songName, int minutes
        , int seconds)
    {
        if (!string.IsNullOrEmpty(artistName))
        {
            if (!string.IsNullOrEmpty(songName))
            {
                if (artistName.Length > 3 && artistName.Length < 20)
                {
                    if (songName.Length > 3 && songName.Length < 30)
                    {
                        if (minutes >= 0 && seconds >= 0
                            || (minutes <= 14 && seconds <= 59))
                        {
                            if (minutes >= 0 && minutes <= 14)
                            {
                                if (seconds >= 0 && seconds <= 59)
                                {
                                    var minToSecs = minutes * 60;
                                    var totalLengthInt = minToSecs + seconds;
                                    TimeSpan totalLength = TimeSpan.FromSeconds(totalLengthInt);
                                    var song = new Song(artistName, songName, totalLength);
                                }
                                else
                                {
                                    InvalidSongSecondsException();
                                }
                            }
                            else
                            {
                                InvalidSongMinutesException();
                            }
                        }
                        else
                        {
                            InvalidSongLengthException();
                        }
                    }
                    else
                    {
                        InvalidSongNameException();
                    }
                }
                else
                {
                    InvalidArtistNameException();
                }
            }
            else
            {
                InvalidSongException();
            }
        }
        else
        {
            InvalidSongException();
        }
    }
    private void InvalidSongException()
    {
        throw new ArgumentException("Invalid song.");
    }

    private void InvalidArtistNameException()
    {
        throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
    }

    private void InvalidSongNameException()
    {
        throw new ArgumentException("Song name should be between 3 and 30 symbols.");
    }

    private void InvalidSongLengthException()
    {
        throw new ArgumentException("Invalid song length.");
    }
    private static void InvalidSongMinutesException()
    {
        throw new ArgumentException("Song minutes should be between 0 and 14.");
    }
    private static void InvalidSongSecondsException()
    {
        throw new ArgumentException("Song seconds should be between 0 and 59.");
    }
}