/* Abstraction */

// abstract class Animal
// {
//   public abstract void animalSound();
//   public void sleep()
//   {
//     Console.WriteLine("Zzz");
//   }
// }

// class Pig: Animal
// {
//   public override void animalSound()
//   {
//     Console.WriteLine("The pig says: wawaweee");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Pig myPig = new Pig();
//     myPig.animalSound();
//     myPig.sleep();
//   }
// }

/* Inteface */
interface IAnimal
{
  void animalSound();
}

class Pig: IAnimal
{
  public void animalSound()
  {
    Console.WriteLine("The pig say jujuuu!");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig();
    myPig.animalSound();
  }
}