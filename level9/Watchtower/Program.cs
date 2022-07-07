// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter x: ");
int x = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Enter y: ");
int y = Convert.ToInt32(Console.ReadLine()!);

string location = "";

if (x < 0 && y > 0)
{
    location = "to the northwest";
}
if (x == 0 && y > 0)
{
    location = "to the north";
}
if (x > 0 && y > 0)
{
    location = "to the northeast";
}
if (x < 0 && y == 0)
{
    location = "to the west";
}
if (x == 0 && y == 0)
{
    location = "here";
}
if (x < 0 && y < 0)
{
    location = "to the southwest";
}
if (x > 0 && y == 0)
{
    location = "to the east";
}
if (x == 0 && y < 0)
{
    location = "to the south";
}
if (x > 0 && y < 0)
{
    location = "to the southeast";
}
Console.WriteLine($"The enemy is {location}!");



