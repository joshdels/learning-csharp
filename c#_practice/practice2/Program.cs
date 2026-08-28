// Conditions 

int time = 22;
if (time < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (time < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}

// Shortcuts
int time2 = 20;
string result = (time2 < 18) ? "Good day" : "Good evening";
Console.WriteLine(result);

// While loop
int i = 0;
while ( i < 5 )
{
  Console.WriteLine(i);
  i++;
}

//For loop
for (int z = 0; z < 5; z++ )
{
  Console.WriteLine(z);
}

string[] cars = {"Volvo", "BMW", "Ford"};
foreach (string v in cars)
{
  Console.WriteLine(v);
}

// Break
for (int j = 0; j < 10; j++) 
{
  if (j == 4) 
  {
    break;
  }
  Console.WriteLine(j);
}

// Cars
int[] myNum = {10, 20, 30, 40};
Console.WriteLine(myNum[0]);