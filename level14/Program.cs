// See https://aka.ms/new-console-template for more information
int round = 1;
int mantHealth = 10;
int cityHealth = 15;
int mantLocation;

RunGame();

void RunGame()
{
    Prompt();
    Console.Clear();
    while (mantHealth > 0 && cityHealth > 0)
    {

        Status(); // call to status
        ComputeDamage(); // display damage dealt during the round 


    }
}

void Prompt()
{
    Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore?");
    mantLocation = Convert.ToInt32(Console.ReadLine()!);
    Console.Clear();
    Console.WriteLine("Player 2, it is your turn.");
}

void ComputeDamage()
{
    int damage = 0;
    if (round % 5 == 0 && round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        damage = 10;
    }
    else if (round % 5 == 0 || round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        damage = 3;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        damage = 1;
    }
    Console.WriteLine($"The cannon is expected to deal {damage} this round.");
    Console.ForegroundColor = ConsoleColor.White;
}


void PrintLine()
{
    for (int i = 0; i < 40; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
}

void Status()
{
    PrintLine();
    Console.WriteLine($"STATUS: ROUND: {round} City: {cityHealth}/15 Manticore: {mantHealth}/10");
}

void OverUnder(int range, int target)
{
    if (target < range)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else if (target > range)
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
    }
}

void WinOrLose(bool won)
{
    if (won)
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been save!");
    }
    else
    {
        Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");
    }
}





