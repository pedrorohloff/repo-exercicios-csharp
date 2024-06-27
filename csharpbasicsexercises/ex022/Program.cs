/* 22. Write a C# program to check if the given integer is within 20 of 100 or 200.
Sample Output:
Input an integer:
25
False 
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input a number:");
        int x = int.Parse(Console.ReadLine());

        if (Math.Abs(100 - x) <= 20 || Math.Abs(200 - x) <= 20)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}