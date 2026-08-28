enum Months
{
    January,
    February,
    March = 6,
    April,
    May,
    June,
    July
}

class Program
{
    static void Main(string[] args)
    {
        int myNum = (int)Months.April;

        Console.WriteLine(myNum);
    }
}

// class Program
// {
//   enum Level
//   {
//     Low, Medium, High
//   }
//   static void Main(string[] args)
//   {
//     Level myVar = Level.Medium;
//     Console.WriteLine(myVar);
//   }
// }

