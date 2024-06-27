/*
20. Write a C# program to get the absolute value of the difference between two given numbers. 
Return double the absolute value of the difference if the first number is greater than the second number.
*/


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Input second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        int difference = firstNumber - secondNumber;

        Console.WriteLine(Math.Abs(difference));
    }
}