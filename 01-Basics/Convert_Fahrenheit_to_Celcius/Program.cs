 // Store a Fahrenheit temperature
System.Console.Write("Enter the temperature (F): ");
var temperatureFahrenheit = Console.ReadLine();

 // Convert it to Celsius
decimal temperatureCelcius = (Convert.ToDecimal(temperatureFahrenheit) - 32) * 5 / 9;

 // Display the result
 System.Console.WriteLine($"{temperatureFahrenheit}°F?! That's {temperatureCelcius}C°!!");