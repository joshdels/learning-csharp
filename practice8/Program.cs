/*
  Exceptions 
*/

// try
// {
//   int[] myNumbers = { 1, 2, 3};
//   Console.WriteLine(myNumbers[0]);
// }
// catch (Exception e)
// {
//   Console.WriteLine(e.Message);
// }

// using System;

// class Program
// {
//     static void checkAge(int age)
//     {
//         if (age < 18)
//         {
//             throw new ArithmeticException("Access Denied, di paka 18 dong");
//         }
//         else
//         {
//             Console.WriteLine("Yes 18 naka ali boiii");
//         }
//     }

//     static void Main(string[] args)
//     {
//         checkAge(15);
//     }
// }


static void CheckAge(int age)
{
    if (age < 18)
    {
        throw new ArithmeticException("Access Denied, di paka 18 dong");
    }
    else
    {
        Console.WriteLine("Yes 18 naka ali boiii");
    }
}

CheckAge(15);