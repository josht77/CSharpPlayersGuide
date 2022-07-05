// See https://aka.ms/new-console-template for more information

Console.WriteLine($"Number of chocolate eggs collected that day: ");

string numEggsString = Convert.ToInt32(Console.ReadLine()!);

int eachSister = numEggs / 4;
int duckBear = numEggs % 4;

Console.WriteLine($"Each sister gets {eachSister}");
Console.WriteLine($"Each duckbear gets {duckBear}");

// Answer to Final Question: 11, 1, 2

