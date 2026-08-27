// Functions are called methods in C#

static void MyMethod(int age, string fname = "joshua")
{
  Console.WriteLine(fname + " yow!" + age);
}

MyMethod(18);



static int IntMethod(int x, int y)
{
  return x + y;
}

Console.WriteLine(IntMethod(5, 2));

