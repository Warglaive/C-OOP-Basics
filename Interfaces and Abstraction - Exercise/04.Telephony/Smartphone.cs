using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


public class Smartphone : ICalling, IBrowsing
{
    public Smartphone(string[] numbersToCall, string[] sitesToBrowse)
    {
        this.NumbersToCall = numbersToCall;
        this.SitesToBrowse = sitesToBrowse;
    }

    public string[] NumbersToCall { get; }
    public string[] SitesToBrowse { get; }

    public void Browse(string[] sites)
    {
        var pattern = @"^\D*$";
        var regex = new Regex(pattern);
        foreach (var currentSite in sites)
        {
            //validate Site
            if (regex.IsMatch(currentSite))
            {
                BrowseIt(currentSite);
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }

    public void Call(string[] dialNumbers)
    {
        var pattern = @"^\d*$";
        var regex = new Regex(pattern);
        foreach (var currentNumber in dialNumbers)
        {
            //validate Site
            if (regex.IsMatch(currentNumber))
            {
                CallIt(currentNumber);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }

    private void CallIt(string currentNumber)
    {
        Console.WriteLine($"Calling... {currentNumber}");
    }

    private void BrowseIt(string currentSite)
    {
        Console.WriteLine($"Browsing: {currentSite}!");
    }
}

