/* 28. Write a C# program to reverse the words of a sentence.
Sample Output:
Original String: Display the pattern like pyramid using the alphabet.
Reverse String: alphabet. the using pyramid like pattern the Display */

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter string:");
        string original = Console.ReadLine();

        string result = "";
        List<string> listaPalavras = new List<string>();

        string[] palavras = original.Split(new[] { " " }, StringSplitOptions.None);

        for (int i = palavras.Length - 1; i >= 0; i--)
        {
            result += palavras[i] + " ";
        }

        listaPalavras.Add(result);
        foreach (string s in listaPalavras)
        {
            System.Console.WriteLine($"\nReverse String: {s}");
        }

    }
}