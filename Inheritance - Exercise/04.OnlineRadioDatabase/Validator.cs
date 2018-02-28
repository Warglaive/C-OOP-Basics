using System;


public class Validator : Song
{
    public Validator(string artistName, string songName, int minutes
        , int seconds) : base(artistName, songName, minutes, seconds)
    {
        if (!string.IsNullOrEmpty(artistName))
        {
            if (!string.IsNullOrEmpty(songName))
            {
                if (artistName.Length > 3 || artistName.Length < 20)
                {
                    if (songName.Length > 3 || songName.Length < 30)
                    {
                        //Song length should be between 0 second and 14 minutes and 59 seconds.
                        var minToSecs = minutes * 60;
                        var totalLengthInt = minToSecs + seconds;
                        TimeSpan totalLength = TimeSpan.FromMinutes(totalLengthInt);

                        if (totalLength.Minutes >= 0 && totalLength.Seconds >= 0
                            || (totalLength.Minutes <= 14 && totalLength.Seconds <= 59))
                        {
                            if (totalLength.Minutes >= 0 || totalLength.Minutes <= 14)
                            {
                                if (totalLength.Seconds >= 0 || totalLength.Seconds <= 59)
                                {

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