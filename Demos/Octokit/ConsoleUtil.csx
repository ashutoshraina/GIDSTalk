void WriteToConsoleWithColor(string message, ConsoleColor color)
{
	var previousColor = Console.ForegroundColor;
	Console.ForegroundColor = color;
	Console.WriteLine(message);
	Console.ForegroundColor = previousColor;
}