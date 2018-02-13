using System;

public class Program
{
    public static void Main()
    {
        var firstObject = new Person();
        firstObject.Name = "Pesho";
        firstObject.Age = 20;
        var secondObject = new Person();
        secondObject.Name = "Gosho";
        secondObject.Age = 18;
        var thirdPerson = new Person();
        thirdPerson.Name = "Stamat";
        thirdPerson.Age = 43;
    }
}
