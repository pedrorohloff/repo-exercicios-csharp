

System.Console.WriteLine("Input a number:");
int number = int.Parse(Console.ReadLine());

for(int i = 0; i <= 10; i++)
{
    System.Console.WriteLine($"{number} * {i} = {(number * i)}");
}

