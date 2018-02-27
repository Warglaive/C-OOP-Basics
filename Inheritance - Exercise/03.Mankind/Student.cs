using System;
using System.Text;

public class Student : Human
{
    private const int MinFacultyNumberLenght = 5;
    private const int MaxFacultyNumberLenght = 10;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    private string facultyNumber;

    private string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            if (value.Length < MinFacultyNumberLenght 
                || value.Length > MaxFacultyNumberLenght)
            {
                throw  new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Faculty number: {facultyNumber}");
        return stringBuilder.ToString();
    }
}