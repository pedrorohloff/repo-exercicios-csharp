/* 27. Write a C# program and compute the sum of an integer's digits.
Sample Output:
Input a number(integer): 12
Sum of the digits of the said integer: 3  */

// feels like i'm doing everything wrong here but it works


using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Input a number:");
        int input = int.Parse(Console.ReadLine());

        static int[] IntToIntArray (int input)
        {
            int[] digitos = input.ToString().Select(digito => int.Parse(digito.ToString())).ToArray();
            return digitos;
        }

        int[] numeros = IntToIntArray(input);

        int total = 0;
        foreach (var item in numeros)
        {
            total += item;
        }

        Console.WriteLine(total);

    }
}