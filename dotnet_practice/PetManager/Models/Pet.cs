namespace PetManager.Models;

public class Pet
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }

    public Pet(string name, string species, int age)
    {
        Name = name;
        Species = species;
        Age = age;
    }
}