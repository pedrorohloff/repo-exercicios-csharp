
System.Console.WriteLine("Insert first number: ");

double firstNumber = double.Parse(Console.ReadLine());

System.Console.WriteLine("Insert second number: ");

double secondNumber = double.Parse(Console.ReadLine());

double result = firstNumber / secondNumber;

System.Console.WriteLine($"Result: {result.ToString("#.####")}");


