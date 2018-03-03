using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var phoneNumbers = Console.ReadLine().Split();
        var sitesToVisit = Console.ReadLine().Split();
        var smartPhone = new Smartphone(phoneNumbers, sitesToVisit);
        smartPhone.Call(phoneNumbers);
        smartPhone.Browse(sitesToVisit);

    }
}