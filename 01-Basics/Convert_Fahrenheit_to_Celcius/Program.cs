 // Store a Fahrenheit temperature
System.Console.Write("Enter the temperature (F): ");
decimal temperatureFahrenheit = Console.ReadLine();

 // Convert it to Celsius
decimal temperatureCelcius = (Convert.ToInt32(temperatureFahrenheit) - 32) * 5 / 9;

 // Display the result
 System.Console.WriteLine($"{temperatureFahrenheit}°F?! That's {temperatureCelcius}C°!!");