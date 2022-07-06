// See https://aka.ms/new-console-template for more information
int num;
do
{
    Console.WriteLine("User 1, enter a number between 0 and 100: ");
    num = Convert.ToInt32(Console.ReadLine()!);
}
while(num < 0 || num> 100);
Console.Clear();
Console.WriteLine("User 2, guess the number");
int guess;
while(true)
{
    Console.Write("What is your next guess?: ");
    guess = Convert.ToInt32(Console.ReadLine()!);
    if(guess > num) {
        Console.WriteLine($"{guess} is too high.");
    } else if (guess < num)
    {
        Console.WriteLine($"{guess} is too low.");
    } else {
        break;
    }   
}
Console.WriteLine("You guessed the number!");