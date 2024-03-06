using _09.ExplicitInterfaces.Interfaces;

namespace _09.ExplicitInterfaces;
public class Citizen : IPerson, IResident
{
    public Citizen(string name, int age, string country)
    {
        Name = name;
        Age = age;
        Country = country;
    }

    public string Name { get; }

    public int Age { get; }

    public string Country {  get; }

    

    string IResident.GetName()
    {
        return $"Mr/Ms/Mrs {Name}";
    }
    string IPerson.GetName()
    {
        return Name;
    }
}

