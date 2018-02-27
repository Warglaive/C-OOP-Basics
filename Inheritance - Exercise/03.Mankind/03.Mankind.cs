using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class Program
{
    public static void Main()
    {
        try
        {
            var student = FirstLineReadStudent();
            var worker = SecondLineReadWorker();
            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

    private static Worker SecondLineReadWorker()
    {
        var singleWorker = Console.ReadLine().Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries).ToList();
        var workerFirstName = singleWorker[0];
        var workerLastName = singleWorker[1];
        var salary = decimal.Parse(singleWorker[2]);
        var workingHours = decimal.Parse(singleWorker[3]);
        var worker = new Worker(workerFirstName, workerLastName, salary, workingHours);
        return worker;
    }

    private static Student FirstLineReadStudent()
    {
        var singleStudent = Console.ReadLine().Split(new[] { ' ' }
        , StringSplitOptions.RemoveEmptyEntries).ToList();
        var studentFirstName = singleStudent[0];
        var studentLastName = singleStudent[1];
        var studentFacultyNumber = string.Empty;
        studentFacultyNumber = FacultyNumberDigitsLettersOnly(singleStudent, studentFacultyNumber);
        var student = new Student(studentFirstName, studentLastName, studentFacultyNumber);
        return student;
    }

    private static string FacultyNumberDigitsLettersOnly(List<string> singleStudent, string studentFacultyNumber)
    {
        //validate facultyNumber
        var pattern = @"^\w*$";
        var regex = new Regex(pattern);
        if (regex.IsMatch(singleStudent[2]))
        {
            studentFacultyNumber = singleStudent[2];
        }
        else
        {
            throw new ArgumentException("Invalid faculty number!");
        }
        //
        return studentFacultyNumber;
    }
}

