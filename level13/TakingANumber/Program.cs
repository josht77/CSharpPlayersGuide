// See https://aka.ms/new-console-template for more information

Console.WriteLine(AskForNumberInRange("Input number between 0 and 100: ", 1, 100));

int AskForNumberInRange(string text, int min, int max)
{
    Console.WriteLine(text);
    int input = Convert.ToInt32(Console.ReadLine()!);
    while (input > max || input < min)
    {
        Console.WriteLine(text);
        input = Convert.ToInt32(Console.ReadLine()!);
    }
    return input;

}
