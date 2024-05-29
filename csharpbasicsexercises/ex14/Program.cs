

System.Console.WriteLine("Enter the amount in celsius: ");
double temperatureInCelsius = double.Parse(Console.ReadLine());

double temperatureKelvin = temperatureInCelsius + 273.5;
double temperatureFahrenheit = ((temperatureInCelsius * 9) / 5) + 32;

System.Console.WriteLine($"Kelvin = {temperatureKelvin}");
System.Console.WriteLine($"Fahrenheit = {temperatureFahrenheit}");
