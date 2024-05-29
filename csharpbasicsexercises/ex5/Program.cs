

System.Console.WriteLine("Input the first number: ");

int firstNumber = int.Parse(Console.ReadLine());

System.Console.WriteLine("Input the second number: ");

int secondNumber = int.Parse(Console.ReadLine());
int placeholder;

placeholder = firstNumber;
firstNumber = secondNumber;
secondNumber = placeholder;

System.Console.WriteLine($"After Swapping:");
System.Console.WriteLine($"First Number: {firstNumber}");
System.Console.WriteLine($"Second Number: {secondNumber}");
