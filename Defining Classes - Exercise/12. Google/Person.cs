using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private Company company;
    private Parents parents;
    private Children children;
    private Car car;

    public void Person(string Name, Company Company, Parents Parents, Children Children, Car Car)
    {
        this.name = Name;
        this.company = Company;
        this.parents = Parents;
        this.children = Children;
        this.car = Car;
    }
}