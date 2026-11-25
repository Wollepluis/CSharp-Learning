 // Generate a random number of days until expiration
Random random = new Random();
int daysUntilExpiration = random.Next(12); // returns a random number from 0 to 11.
int discountPercentage = 0;

 // Display an expiration message based on the days remaining
if (daysUntilExpiration == 0)
{
    System.Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    System.Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    System.Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    System.Console.WriteLine("Your subscription will expire soon. Renew now!");
}

 // Display a discount message if a discount applies
if (discountPercentage > 0)
{
    System.Console.WriteLine($"Renew now and save {discountPercentage}%.");
}