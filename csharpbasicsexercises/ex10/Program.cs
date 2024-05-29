
System.Console.WriteLine("Enter first number - ");
int x = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter second number - ");
int y = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter third number - ");
int z = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, " +
                         $"(x+y)*z is {((x+y)*z)} and x*y + y*z is {((x*y) + (y*z))}");

