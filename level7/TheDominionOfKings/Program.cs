// See https://aka.ms/new-console-template for more information


Console.WriteLine("How many provinces?: ");
int numProvinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies?: ");
int numDuchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many estates?: ");
int numEstates = Convert.ToInt32(Console.ReadLine());

int total = (numProvinces * 6) + (numDuchies * 3) + (numEstates * 1);

Console.WriteLine($"Total score: {total}");