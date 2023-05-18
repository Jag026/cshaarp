Console.Write("How many times have you watched Space Balls?");

string viewings = Console.ReadLine();

try 
{
    int views = int.Parse(viewings);
    Console.WriteLine(views);
}
catch (FormatException)
{
    Console.WriteLine("You didn't provide a number");
}
catch (OverflowException)
{
    Console.WriteLine("Too many viewings");
}

