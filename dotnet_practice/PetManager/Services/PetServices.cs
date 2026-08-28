using PetManager.Models;

namespace PetManager.Services;

public class PetService
{
    public void DisplayPet(Pet pet)
    {
        Console.WriteLine($"Name: {pet.Name}");
        Console.WriteLine($"Species: {pet.Species}");
        Console.WriteLine($"Age: {pet.Age}");
    }
}