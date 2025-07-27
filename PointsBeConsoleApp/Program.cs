using PointsBeConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        string[] quoteText;
        if (args.Length > 1)
        {
            quoteText = args;
        }
        else
        {
            quoteText = ["Sachin", "Virat", "Joe", "William", "Steve", "Shaq"]; //Default
        }


        Console.WriteLine($"Single Quote Output: \n {StringFormatter.ToCommaSeparatedList(quoteText, '\'')}");

        Console.WriteLine($"Double Quote Output: \n {StringFormatter.ToCommaSeparatedList(quoteText, '\"')}");
    }
}