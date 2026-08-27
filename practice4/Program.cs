//  OOP

// class Car
// {
//   public string color = "red"; // fields
//   public string model; // fields
//   public int year;

//   public void fullThrottle() // methods 
//   {
//     Console.WriteLine("The car is going as fast as it can!");
//   }
//   //Constructor
//   public Car(string modelName, string modelColor, int modelYear)
//   {
//     model = modelName;
//     color = modelColor;
//     year = modelYear;
//   } // this will be the constructor

//   static void Main(string[] args)
//   {
//     Car myObj1 = new Car("Mustang", "Red", 1999);
//     Console.WriteLine(myObj1.color);
//     myObj1.fullThrottle();
//   }
// }

// Properties
class Person
{
  private string name; // field
  public string Name   // property
  {
    get { return name; }
    set { name = value; }
  }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Joshua";
    Console.WriteLine(myObj.Name);
  }
}

