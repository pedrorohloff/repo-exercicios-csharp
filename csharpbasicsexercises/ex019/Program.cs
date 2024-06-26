/*
19. Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum. 
*/

System.Console.WriteLine("Input fisrt integer:");
int firstNumber = int.Parse(Console.ReadLine());

System.Console.WriteLine("Input second integer:");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine(firstNumber == secondNumber ? firstNumber * 3 : firstNumber + secondNumber);












