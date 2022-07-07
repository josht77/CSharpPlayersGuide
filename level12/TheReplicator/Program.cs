// See https://aka.ms/new-console-template for more information

int[] ogArray = new int[5];
int[] newArr = new int[5];
int input;

for(int i = 0; i < 5; i++) {
    Console.WriteLine("Input a number: ");
    input = Convert.ToInt32(Console.ReadLine()!);
    ogArray[i] = input;
}

for(int i = 0; i < 5; i++) {
    newArr[i] = ogArray[i];
}
for(int i = 0; i < 5; i++){
    Console.WriteLine($"{ogArray[i]} {newArr[i]}");
}

