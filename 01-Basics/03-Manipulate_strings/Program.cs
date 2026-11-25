// Use the '+' operator to join strings together.
string first = "Hello";
string last = "world";
string message = first + ", " + last + "!";
System.Console.WriteLine(message);

// Cleaner way is to use string interpolation, using a '$' before the quote and placing variables between '{}'.
string name = "Mark";
System.Console.WriteLine($"Hello, {name}!");

// .ToUpper() converts string to uppercase.
string uppercase = "uppercase".ToUpper();
string lowercase = "LOWERCASE".ToLower();
string changeText = "Mark".Replace("M", "B");
System.Console.WriteLine($"{uppercase} {lowercase} {changeText}");

// .Length displays the amount of characters
string characterLength = "characters";
System.Console.WriteLine(characterLength.Length);