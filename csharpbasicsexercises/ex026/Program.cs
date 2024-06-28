/* 
26. Write a C# program to compute the sum of the first 500 prime numbers.
Sample Output:
Sum of the first 500 prime numbers:
824693
*/


 // you should train maths more frequently
internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;
        int ctr = 0;
        int n = 2;

        while (ctr < 500)
        {
            if (isPrime(n))
            {
                sum += n;
                ctr++;
            }
            n++;
        }
        System.Console.WriteLine(sum);

    }

    public static bool isPrime (int n)
    {
        int x = (int)Math.Floor(Math.Sqrt(n));

        if ( n == 1 ) return false;
        if ( n == 2 ) return true;

        for ( int i = 2; i <= x; ++i)
        {
            if ( n % i == 0) return false;
        }

        return true;
    }

}