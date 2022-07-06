// See https://aka.ms/new-console-template for more information
string blast = " ";
for (int i = 1; i < 101; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        blast = "Elctric and Fire";
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        blast = "Electric";
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        blast = "Fire";
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        blast = "Normal";
    }
    Console.WriteLine($"{i}: {blast}");
}


