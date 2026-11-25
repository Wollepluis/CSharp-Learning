// Ask for the user's name
System.Console.Write("What is your name? ");
string? name = Console.ReadLine();

// Ask for the user's age
System.Console.Write("What is your age? ");
string? age = Console.ReadLine();

// Display a personalized message that includes both pieces of information
System.Console.WriteLine($"Hello, {name}! With an age of {age}, you're very old...");