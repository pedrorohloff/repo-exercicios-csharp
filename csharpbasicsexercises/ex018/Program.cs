/*
18. Write a C# program to check a pair of integers and return true if one is negative and one is positive.
Sample Output:
Input first integer:
-5
Input second integer:
25
Check if one is negative and one is positive:
True 
*/

Console.WriteLine("Input first integer:");
int fisrtInteger = (int.Parse(Console.ReadLine()));

Console.WriteLine("Input second integer:");
int secondInteger = (int.Parse(Console.ReadLine()));

if (fisrtInteger > 0 && secondInteger < 0)
{
    Console.WriteLine("True");
}
else if (fisrtInteger < 0 && secondInteger > 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}


