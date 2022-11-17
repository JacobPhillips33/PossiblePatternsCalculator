using Codewars_ScreenLockingPatterns;

var cont = "yes";

Console.WriteLine("This application will calculate the number of possible patterns starting\n" +
                  "from a given first grid point and designating a pattern length.");
Console.WriteLine();

Console.WriteLine("Rules: ");
Console.WriteLine("       1. Grid points cannot be repeated, they can only be used once, at most.");
Console.WriteLine("       2. Cannot pass through a point unless it has already been used. ");
Console.WriteLine("          Example: Cannot go from A -> G unless D has already been used.");

while (cont == "yes")
{   
    Console.WriteLine();
    Console.WriteLine("     Grid point options");
    Console.WriteLine("          A  B  C");
    Console.WriteLine("          D  E  F");
    Console.WriteLine("          G  H  I");
    Console.WriteLine();

    Console.Write("Please enter a starting point from the grid above: ");
    var startingPoint = Console.ReadLine().ToUpper();
    Console.WriteLine();

    while (startingPoint != "A" && startingPoint != "B" && startingPoint != "C" &&
           startingPoint != "D" && startingPoint != "E" && startingPoint != "F" &&
           startingPoint != "G" && startingPoint != "H" && startingPoint != "I")
    {
        Console.Write("Invalid starting point. Please enter a valid starting point between A -> I: ");
        startingPoint = Console.ReadLine().ToUpper();
        Console.WriteLine();
    }

    char firstDot = startingPoint[0];

    Console.Write("Please enter a pattern length: ");
    var patternLengthParsable = int.TryParse(Console.ReadLine(), out var patternLength);
    Console.WriteLine();

    while (!patternLengthParsable || patternLength < 1 || patternLength > 9)
    {
        Console.WriteLine("Invalid pattern length. Please input a valid number between 1-9.");
        patternLengthParsable = int.TryParse(Console.ReadLine(), out patternLength);
    }

    var answer = Methods.CountPatternsFrom(firstDot, patternLength);

    Console.WriteLine($"A pattern length of {patternLength} moves starting at grid point {startingPoint}" +
                      $" has {answer} possible patterns.");

    Console.WriteLine();
    Console.Write("Would you like to calculate another option? \"Yes\" or \"No\": ");
    cont = Console.ReadLine().ToLower();
    Console.WriteLine();

    while (cont != "yes" && cont != "no")
    {
        Console.Write("Invalid input. Please enter \"Yes\" or \"No\": ");
        cont = Console.ReadLine().ToLower();
        Console.WriteLine();
    }    
}
Console.WriteLine("Have a great day!");


