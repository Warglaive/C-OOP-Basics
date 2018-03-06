using System;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split().ToList();
        var removeOperation = int.Parse(Console.ReadLine());

        var addCollection = new AddCollection();
        var addRemoveCollection = new AddRemoveCollection();
        var myList = new MyList();

        for (int i = 0; i < removeOperation; i++)
        {
        }
    }
}