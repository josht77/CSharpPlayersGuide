// See https://aka.ms/new-console-template for more information

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue; // Start higher than anuthing in the array
foreach (int i in array)
{
    if (i < currentSmallest)
    {
        currentSmallest = i;
    }
}
Console.WriteLine($"Smallest: {currentSmallest}");

int total = 0;
foreach (int j in array)
{
    total += j;
}
float average = (float)total / array.Length;
Console.WriteLine($"Average: {average}");