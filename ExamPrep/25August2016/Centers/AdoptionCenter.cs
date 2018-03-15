using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AdoptionCenter
{
    public string Name { get; set; }
    private List<Animal> storedAnimals;

    public List<Animal> StoredAnimals
    {
        get { return storedAnimals; }
        set { storedAnimals = value; }
    }

    //public List<Animal> SendAnimals(List<Animal> animals)
    //{
    //    return animals;
    ////}
    //public List<Animal> AdoptAllCleansedAnimals(List<Animal> cleansedAnimals)
    //{
    //    return cleansedAnimals;
    //}
}