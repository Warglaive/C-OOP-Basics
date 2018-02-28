using System;
using System.Text;


public class Validator
{
    public Validator(string artistName, string songName, int minutes
        , int seconds)
    {
        if (!string.IsNullOrEmpty(artistName))
        {
            if (!string.IsNullOrEmpty(songName))
            {
                if (artistName.Length >= 3 && artistName.Length <= 20)
                {
                    if (songName.Length >= 3 && songName.Length <= 30)
                    {
                        //check total length
                        var currentSongTotalLength = minutes * 60 + seconds;
                        var length = TimeSpan.FromSeconds(currentSongTotalLength);

                        if (length.Seconds >= 0
                            && length.Seconds <= 59
                            || length.Minutes >= 0
                            && length.Minutes <= 14)
                        {
                            if (minutes >= 0 && minutes <= 14)
                            {
                                if (seconds >= 0 && seconds <= 59)
                                {
                                    Console.WriteLine("Song added.");
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