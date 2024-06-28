/* 29. Write a C# program to find the size of a specified file in bytes.
Sample Output:
Size of a file: 31  */


using System;
using System.Collections.Generic;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        /*  como ler tamanho da string entrada pelo user 
        Console.WriteLine("Input string: ");
        string input = Console.ReadLine();

        var byteCount = input.Length * sizeof(char);

        Console.WriteLine($"Size of a string: {byteCount}"); */

        FileInfo novoArquivo = new FileInfo("text.txt");
        System.Console.WriteLine($"\n Size of a file: {novoArquivo.Length.ToString()}");
    }
}