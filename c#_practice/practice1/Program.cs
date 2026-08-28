using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World! Joshua");  
      Console.WriteLine("I am Learning C#");
      // Console.WriteLine("It is awesome");
      Console.WriteLine(3 + 3);

      string name = "Joshua";
      Console.WriteLine(name);

      int myNum = 15;
      myNum = 5;
      Console.WriteLine(myNum);

      string firstName = "John ";
      string lastName = "Doe";
      string fullName = firstName + lastName;
      Console.WriteLine(fullName);

      int myInt = 10;
      Console.WriteLine(Convert.ToString(myInt));
    
      Console.WriteLine("Enter Username");
      string userName = Console.ReadLine();
      Console.WriteLine("Username is: " + userName);

      Console.WriteLine("Enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your age is: " + age);
    }
  }
}
