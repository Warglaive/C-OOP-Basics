using System;
using System.Text;


public class Worker : Human
{
    private const int MinWorkingHours = 1;
    private const int MaxWorkingHours = 12;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }
    private decimal weekSalary;
    private decimal workHoursPerDay;

    private decimal WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            if (value < MinWorkingHours || value > MaxWorkingHours)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workHoursPerDay = value;
        }
    }

    private decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    private decimal SalaryPerHour()
    {
        var salaryPerHour = WeekSalary / (5m * WorkHoursPerDay);
        return salaryPerHour;
    }
    public override string ToString()
    {
        //week salary / 5 working days * hours per day = salary per hour
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {WeekSalary:f2}")
            .AppendLine($"Hours per day: {WorkHoursPerDay:f2}")
            .AppendLine($"Salary per hour: {this.SalaryPerHour():f2}");
        return stringBuilder.ToString();
    }
}