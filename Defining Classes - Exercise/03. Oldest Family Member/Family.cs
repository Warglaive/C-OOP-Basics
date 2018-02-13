using System.Collections.Generic;

public class Family
{
    public List<Person> family = new List<Person>();
    public void AddMember(Person member)
    {
        family.Add(member);
    }
    public Person GetOldestMember()
    {
        var biggestNum = int.MinValue;
        var oldestPerson = new Person();
        foreach (var currentPerson in family)
        {
            if (currentPerson.Age > biggestNum)
            {
                biggestNum = currentPerson.Age;
                oldestPerson = currentPerson;
            }
        }
        return oldestPerson;
    }
}