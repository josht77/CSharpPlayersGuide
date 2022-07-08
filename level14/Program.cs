// See https://aka.ms/new-console-template for more information
int round = 1;
int mantHealth = 10;
int cityHealth = 15;
int damage;

RunGame();

void RunGame()
{
    int range = Prompt("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Player 2, it is your turn.");
    while (mantHealth > 0 && cityHealth > 0)
    {
        Status(); // call to status
        damage = ComputeDamage(round);
        Console.WriteLine($"The cannon is expected to deal {damage} damage this round"); // display damage dealt during the round 
        Console.ForegroundColor = ConsoleColor.White;
        int target = AskNum("Enter desired cannon range: ");
        Console.ForegroundColor = ConsoleColor.White;
        OverUnder(target, range);
        cityHealth--;
        round++;
    }
    WinOrLose(cityHealth > 0);
}

int Prompt(string text, int min, int max)
{
    while (true)
    {
        int num = AskNum(text);
        if (num >= min && num < max)
        {
            return num;
        }
    }
}

int ComputeDamage(int round)
{
    if (round % 5 == 0 && round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        return 10;
    }
    else if (round % 5 == 0 || round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        return 3;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        return 1;
    }
}


void PrintLine()
{
    for (int i = 0; i < 40; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
}

int AskNum(string desc)
{
    Console.Write(desc + " ");
    Console.ForegroundColor = ConsoleColor.Blue;
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void Status()
{
    PrintLine();
    Console.WriteLine($"STATUS: ROUND: {round} City: {cityHealth}/15 Manticore: {mantHealth}/10");
}

void OverUnder(int target, int range)
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

        Console.Write("That round was a ");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("DIRECT HIT!");
        Console.ForegroundColor = ConsoleColor.White;
        mantHealth -= damage;
    }
}

void WinOrLose(bool won)
{
    if (won)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");
    }
}