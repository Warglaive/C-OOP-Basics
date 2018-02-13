using System;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var family = new Family();
        for (int i = 0; i < n; i++)
        {
            var currentPerson = new Person();
            var currentMemberNameAge = Console.ReadLine()
                .Split();
            var name = currentMemberNameAge[0];
            var age = int.Parse(currentMemberNameAge[1]);
            currentPerson.Age = age;
            currentPerson.Name = name;
            family.AddMember(currentPerson);
        }
        Console.WriteLine(
            $"{family.GetOldestMember().Name}" +
            $" {family.GetOldestMember().Age}");
    }
}