using System;
using System.Globalization;
using System.Linq;
using System.Text;


public class Book
{
    private string author;
    private string title;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Author
    {
        get { return author; }
        set
        {
            var nameParts = value.Split().ToList();
            if (nameParts.Count > 1)
            {
                var secondName = nameParts[1][0].ToString(); //take first char of 2nd name
                var isDigit = int.TryParse(secondName, NumberStyles.Any, //may be bug
                    CultureInfo.InvariantCulture, out _);
                if (isDigit)
                {
                    throw new ArgumentException("Author not valid!");
                }
            }

            author = value;
        }
    }
    public string Title
    {
        get { return title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }
    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");

        var result = resultBuilder.ToString().TrimEnd();
        return result;
    }
}

