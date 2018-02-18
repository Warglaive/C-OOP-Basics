using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var result = new Dictionary<string, Person>();
        var currentParents = new Parents();
        var currentChildren = new Children();
        var currentCar = new Car();

        var currentPerson = new Person();
        while (input != "End")
        {
            var inputArgs = input.Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            //add to Dictionary
            var personName = inputArgs[0];
            var subClass = inputArgs[1];
            switch (subClass)
            {
                case "company":
                    AddCompany(inputArgs, personName, result);
                    break;
                case "car":
                    AddCar(inputArgs, personName, result);
                    break;
                case "pokemon": //Multiple
                    AddPokemon(currentPerson, inputArgs, personName, result);
                    break;
                case "parents": //Multiple
                    AddParents(currentPerson, inputArgs, personName, result);
                    break;
                case "children":
                    AddChildred(currentPerson,inputArgs, personName, result);
                    break;
            }
            input = Console.ReadLine();
        }
        Print(result);
    }

    private static void Print(Dictionary<string, Person> result)
    {
        var printName = Console.ReadLine();
        Console.WriteLine($"{printName}");
        foreach (var currentPerson in result)
        {
            if (currentPerson.Key == printName)
            {
                //Print Company 1st
                Console.WriteLine("Company:");
                //Null check
                if (currentPerson.Value.Company != null)
                {
                    Console.WriteLine($"{currentPerson.Value.Company.CompanyName} " +
                                      $"{currentPerson.Value.Company.Department} {currentPerson.Value.Company.Salary:f2}");
                }

                //Print Car 2nd
                Console.WriteLine("Car:");
                //Null check
                if (currentPerson.Value.Car != null)
                {
                    Console.WriteLine($"{currentPerson.Value.Car.CarModel} {currentPerson.Value.Car.CarSpeed}");
                }

                //print Pokemon
                Console.WriteLine("Pokemon:");
                //Null check
                if (currentPerson.Value.Pokemon != null)
                {
                    foreach (var currentPokemon in currentPerson.Value.Pokemon)
                    {
                        Console.WriteLine($"{currentPokemon.PokemonName} {currentPokemon.PokemonType}");
                    }
                }


                //Print Parents
                Console.WriteLine("Parents:");
                //Null check
                if (currentPerson.Value.Parents != null)
                {
                    foreach (var currentParent in currentPerson.Value.Parents)
                    {
                        Console.WriteLine($"{currentParent.ParentName} {currentParent.ParentBirthday}");
                    }
                }


                //Print Children
                Console.WriteLine("Children:");
                //Null check
                if (currentPerson.Value.Children != null)
                {
                    foreach (var currentChild in currentPerson.Value.Children)
                    {
                        Console.WriteLine($"{currentChild.ChildName} {currentChild.ChildBirthday}");
                    }
                }
            }
        }
    }

    private static void AddChildred(Person currentPerson, List<string> inputArgs, string personName, Dictionary<string, Person> result)
    {
        //add to currentChildren
        var currentChildren = new Children();
        currentChildren.ChildName = inputArgs[2];
        currentChildren.ChildBirthday = inputArgs[3];
        //add to currentPerson
        if (currentPerson.Children == null)
        {
            currentPerson.Children = new List<Children>();
        }
        currentPerson.Children.Add(currentChildren);

        if (!result.ContainsKey(personName))
        {
            result.Add(personName, new Person());
        }
        if (result[personName].Children == null)
        {
            result[personName].Children = new List<Children>();
        }
        result[personName].Children.Add(currentChildren);
    }

    private static void AddParents(Person currentPerson, List<string> inputArgs, string personName, Dictionary<string, Person> result)
    {
        //add to currentParents
        var currentParents = new Parents();
        currentParents.ParentName = inputArgs[2];
        currentParents.ParentBirthday = inputArgs[3];
        ////add to currentPerson

        if (currentPerson.Parents == null)
        {
            currentPerson.Parents = new List<Parents>();
        }
        currentPerson.Parents.Add(currentParents);

        if (!result.ContainsKey(personName))
        {
            result.Add(personName, new Person());
        }
        if (result[personName].Parents == null)
        {
            result[personName].Parents = new List<Parents>();
        }
        result[personName].Parents.Add(currentParents);
    }

    private static void AddPokemon(Person currentPerson, List<string> inputArgs, string personName, Dictionary<string, Person> result)
    {
        //add to currentPokemon
        var currentPokemon = new Pokemon();
        currentPokemon.PokemonName = inputArgs[2];
        currentPokemon.PokemonType = inputArgs[3];
        //add to currentPerson
        if (currentPerson.Pokemon == null)
        {
            currentPerson.Pokemon = new List<Pokemon>();
        }
        currentPerson.Pokemon.Add(currentPokemon);

        if (!result.ContainsKey(personName))
        {
            result.Add(personName, new Person());
        }
        if (result[personName].Pokemon == null)
        {
            result[personName].Pokemon = new List<Pokemon>();
        }
        result[personName].Pokemon.Add(currentPokemon);
    }

    private static void AddCar(List<string> inputArgs, string personName, Dictionary<string, Person> result)
    {
        //add to currentCar
        var currentCar = new Car();
        currentCar.CarModel = inputArgs[2];
        currentCar.CarSpeed = decimal.Parse(inputArgs[3]);
        //add to currentPerson
        if (!result.ContainsKey(personName))
        {
            result.Add(personName, new Person());
        }
        result[personName].Car = currentCar;
    }

    private static void AddCompany(List<string> inputArgs, string personName, Dictionary<string, Person> result)
    {
        //add to currentCompany
        var currentCompany = new Company();
        currentCompany.CompanyName = inputArgs[2];
        currentCompany.Department = inputArgs[3];
        currentCompany.Salary = decimal.Parse(inputArgs[4]);
        //add to currentPerson
        if (!result.ContainsKey(personName))
        {
            result.Add(personName, new Person());
        }
        result[personName].Company = currentCompany;
    }
}

