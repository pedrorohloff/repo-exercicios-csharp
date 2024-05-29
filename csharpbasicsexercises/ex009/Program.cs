
System.Console.WriteLine("Input first number:");
int firstNumber = int.Parse(Console.ReadLine());

System.Console.WriteLine("Input second number:");
int secondNumber = int.Parse(Console.ReadLine());

System.Console.WriteLine("Input third number:");
int thirdNumber = int.Parse(Console.ReadLine());

System.Console.WriteLine("Input fourth number:");
int fourthNumber = int.Parse(Console.ReadLine());

double average = (double)(firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

System.Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} is: {average}");

