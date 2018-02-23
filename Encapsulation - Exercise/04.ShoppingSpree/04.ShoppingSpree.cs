using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        try
        {
            string[] productsInput;
            List<Person> people;
            List<Product> products;
            var peopleInput = PeopleAndProductsInput(out productsInput, out people, out products);
            BuyProducts(peopleInput, people, productsInput, products);
            FinalPrint(people, products);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void FinalPrint(List<Person> people, List<Product> products)
    {
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            var tokens = command.Split();

            var personName = tokens[0];
            var productName = tokens[1];

            var person = people.First(p => p.Name == tokens[0]);
            var product = products.First(p => p.Name == productName);

            var output = person.TryBuyProduct(product);
            Console.WriteLine(output);
        }
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }

    private static void BuyProducts(string[] peopleInput, List<Person> people, string[] productsInput, List<Product> products)
    {
        foreach (var personInput in peopleInput)
        {
            var tokens = personInput.Split('=');
            var personName = tokens[0];
            var personMoney = decimal.Parse(tokens[1]);

            var person = new Person(personName, personMoney);

            people.Add(person);
        }
        foreach (var productInput in productsInput)
        {
            var tokens = productInput.Split('=');
            var productName = tokens[0];
            var productPrice = decimal.Parse(tokens[1]);

            var product = new Product(productName, productPrice);

            products.Add(product);
        }
    }

    private static string[] PeopleAndProductsInput(out string[] productsInput, out List<Person> people, out List<Product> products)
    {
        var peopleInput = Console.ReadLine()
            .Split(new[] { ';' },
                StringSplitOptions.RemoveEmptyEntries);

        productsInput = Console.ReadLine()
            .Split(new[] { ';' },
                StringSplitOptions.RemoveEmptyEntries);

        people = new List<Person>();
        products = new List<Product>();
        return peopleInput;
    }
}
