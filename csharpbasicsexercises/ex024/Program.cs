
/* 24. Write a C# program to find the longest word in a string.
Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
Sample Output:
following */

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input string:");
        string x = Console.ReadLine();

        string[] arrString = SepararPorEspaco(x);

        Console.WriteLine($"Maior palavra: {MaiorPalavra(arrString)}");

    }

    public static string[] SepararPorEspaco(string x)
    {
        return x.Split(" ");
    }

    public static string MaiorPalavra(string[] array)
    {
        int tamanhoPalavra = 0;
        string maiorPalavra = string.Empty;

        foreach (var palavra in array)
        {
            if (palavra.Length > tamanhoPalavra)
            {
                tamanhoPalavra = palavra.Length;
                maiorPalavra = palavra;
            }
        }
        return maiorPalavra;
    }



}