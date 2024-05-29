

System.Console.WriteLine("Enter a digit: ");
int number = int.Parse(Console.ReadLine());

for(int i = 0; i <= 3; i++)
{
    if(i % 2 == 0)
    {
        System.Console.WriteLine($"{number} {number} {number} {number}");
    }
    else
    {
        System.Console.WriteLine($"{number}{number}{number}{number}");
    }
}


