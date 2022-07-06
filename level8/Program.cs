// See https://aka.ms/new-console-template for more information

Console.Title = "Defense of Consolas";


Console.WriteLine("What is the target row?: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the target column?: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine($"({row}, {col - 1})");
Console.WriteLine($"({row - 1}, {col})");
Console.WriteLine($"({row}, {col + 1})");
Console.WriteLine($"({row + 1}, {col})");

Console.Beep();

