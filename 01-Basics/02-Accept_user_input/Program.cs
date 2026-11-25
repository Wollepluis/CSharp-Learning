/* 
Console.ReadLine() prompts a question, use a variable to "save" the user's answer.
It always returns a 'string' even if the user writes a number
*/ 
Console.Write("What is your favorite color? ");
string? favoriteColor = Console.ReadLine();
System.Console.WriteLine("Oh, I love " + favoriteColor + " too!");