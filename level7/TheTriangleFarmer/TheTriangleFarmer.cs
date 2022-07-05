// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Triangle height: ");
string heightString = Console.ReadLine()!;
float height = Convert.ToSingle(heightString)!;

string widthString = Console.ReadLine()!;
float width = Convert.ToSingle(widthString)!;

float area = (width * height) / 2;

Console.WriteLine($"The area is {area}");

