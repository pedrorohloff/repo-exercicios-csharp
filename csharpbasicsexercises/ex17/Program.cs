﻿/*
17. Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
TThe quick brown fox jumps over the lazy dog.T
*/

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine(DupeFirstChar("The quick brown fox jumps over the lazy dog."));

    }

    public static string DupeFirstChar(string s)
    {
        return s.Length > 0 ? s.Substring(0, 1) + s + s.Substring(0, 1) : s;
    }

}