using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CleansingCenter
{
    private string name;
    private List<Animal> storedAnimals;

    public CleansingCenter(string name, List<Animal> storedAnimals)
    {
        this.Name = name;
        this.StoredAnimals = storedAnimals;
    }

    public List<Animal> StoredAnimals
    {
        get { return storedAnimals; }
        set { storedAnimals = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    //public Animal CleanseAnimals()
    //{
    //    //
    //    return this.StoredAnimals[0];
    //}
}