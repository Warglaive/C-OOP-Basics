using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var employees = new List<Employee>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            var inputArgs = input.Split();
            var currentEmployee = new Employee();

            var name = inputArgs[0];
            var salary = double.Parse(inputArgs[1]);
            var position = inputArgs[2];
            var department = inputArgs[3];
            //
            var email = "n/a";
            var age = -1;
            currentEmployee.Email = email;
            currentEmployee.Age = age;
            //
            if (inputArgs.Length == 5)
            {
                if (!int.TryParse(inputArgs[4], out age))
                {
                    age = -1;
                    email = inputArgs[4];
                    currentEmployee.Email = email;
                }
                else
                {
                    currentEmployee.Age = age;
                }
                currentEmployee.Name = name;
                currentEmployee.Salary = salary;
                currentEmployee.Position = position;
                currentEmployee.Department = department;
                currentEmployee.Email = email;
                currentEmployee.Age = age;

                employees.Add(currentEmployee);
            }
            else if (inputArgs.Length == 6)
            {
                email = inputArgs[4];
                age = int.Parse(inputArgs[5]);

                currentEmployee.Name = name;
                currentEmployee.Salary = salary;
                currentEmployee.Position = position;
                currentEmployee.Department = department;
                currentEmployee.Email = email;
                currentEmployee.Age = age;

                employees.Add(currentEmployee);
            }
            else if (inputArgs.Length == 4) // Mondatory
            {
                name = inputArgs[0];
                salary = double.Parse(inputArgs[1]);
                position = inputArgs[2];
                department = inputArgs[3];

                currentEmployee.Name = name;
                currentEmployee.Salary = salary;
                currentEmployee.Position = position;
                currentEmployee.Department = department;

                employees.Add(currentEmployee);
            }
        }
        //calculate Department with highest average salary
        var groups = employees.GroupBy(e => e.Department);
        var maxAverage = 0d;
        var averageDepartment = string.Empty;
        foreach (var department in groups)
        {
            var currentAverage = department.Average(x => x.Salary);
            if (currentAverage > maxAverage)
            {
                averageDepartment = department.Key;
                maxAverage = currentAverage;
            }
        }
        Console.WriteLine($"Highest Average Salary: {averageDepartment}");

        foreach (var employeePerDepartment in groups)
        {
            if (averageDepartment == employeePerDepartment.Key)
            {
                foreach (var currentEmployee in employeePerDepartment.OrderByDescending(x => x.Salary))
                {
                    Console.WriteLine($"{currentEmployee.Name} {currentEmployee.Salary:f2} {currentEmployee.Email} {currentEmployee.Age}");
                }
            }
        }
    }
}