/*
16. Write a C# program to create a new string from a given string where the first and last characters change their positions.
Test Data:
w3resource
Python
Sample Output:
e3resourcw
nythoP
*/

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine(FisrtLast("Python"));
        System.Console.WriteLine(FisrtLast("w3resource"));
    }
    public static string FisrtLast(string ustr)
    {
        return ustr.Length > 1 
            ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1,  ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
    }
}