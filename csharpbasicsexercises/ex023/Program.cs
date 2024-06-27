/* 23. Write a C# program to convert a given string into lowercase.
Sample Output:
write a c# sharp program to display the following pattern using the alphabet. */



public class Ex023
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input string:");
        string lowercase = Console.ReadLine();

        Console.WriteLine(ConvertToLowerCase(lowercase));
    }
    
    public static string ConvertToLowerCase (string x)
    {
        return x.ToLower();
    }


}




