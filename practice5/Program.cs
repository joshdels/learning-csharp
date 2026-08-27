// class Vehicle
// {
//   public string brand = "Ford";
//   public void honk()
//   {
//     Console.WriteLine("Tricylcle beepbepp");
//   }
// }

// class Car : Vehicle
// {
//   public string modelName = "Mustung";
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Car myCar = new Car();

//     myCar.honk();

//     Console.WriteLine(myCar.brand + " " + myCar.modelName);
//   }
// }

// Polymorphism
class Animal
{
  public virtual void animalSound()
  {
    Console.WriteLine("The animal makes sound");
  }
}

class Pig: Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog: Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The dog says: bowrol!");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Animal myAnimal = new Animal();
    Animal myPig = new Pig();
    Animal myDog = new Dog();

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}