public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }



    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public Person(string FirstName, string LastName, int Age, decimal Salary)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
        this.age = Age;
        this.salary = Salary;
    }
    private decimal salary;

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age > 30)
        {
            this.salary += this.salary * percentage / 100;
        }
        else
        {

            this.salary += this.salary * percentage / 200;
        }
    }
    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} receives {this.salary:f2} leva.";
    }
}
