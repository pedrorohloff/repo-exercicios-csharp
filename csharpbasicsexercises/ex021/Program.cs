/* 
21. Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20. 
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Input second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber == 20 || secondNumber == 20 || firstNumber + secondNumber == 20)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}