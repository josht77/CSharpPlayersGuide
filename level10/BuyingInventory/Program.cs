// See https://aka.ms/new-console-template for more information
Console.WriteLine("The following items are avaliable: ");
List<string> menuItems = new List<string>();
menuItems.Add("Rope");
menuItems.Add("Torches");
menuItems.Add("Climbing Equipment");
menuItems.Add("Clean Water");
menuItems.Add("Machete");
menuItems.Add("Canoe");
menuItems.Add("Food Supplies");
int count = 1;
foreach(string str in menuItems) {
    Console.WriteLine($"{count} - {str}");
    count++;
}
Console.WriteLine("What number do you want to see the price of?: ");
int selection = Convert.ToInt32(Console.ReadLine()!);
int price = 0;
string item = " ";
switch(selection) {
    case 1: 
        price = 10;
        item = "Rope";
        break;
    case 2:
        price = 15;
        item = "Torches";
        break;
    case 3: 
        price = 25;
        item ="Climbing Equipment";
        break;
    case 4:
        price = 1;
        item = "Clean Water";
        break;

    case 5: 
        price = 20;
        item = "Machete";
        break;
    case 6:
        price = 200;
        item = "Canoe";
        break;
    case 7:
        price = 1;
        item = "Food Supplies";
        break;
    default:
        break;

}

Console.WriteLine($"{item} cost {price} gold.");







