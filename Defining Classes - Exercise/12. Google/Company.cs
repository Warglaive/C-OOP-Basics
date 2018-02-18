public class Company
{
    private string companyName;
    private string department;
    private decimal salary;

    public string CompanyName
    {
        get => companyName;
        set => companyName = value;
    }

    public string Department
    {
        get => department;
        set => department = value;
    }

    public decimal Salary
    {
        get => salary;
        set => salary = value;
    }
}