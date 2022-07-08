// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Chest curState = Chest.locked;
string input;
while(true) {
    Console.WriteLine($"The chest is {curState}. What do you want to do?");
    input = Console.ReadLine()!;
    
    if (curState == Chest.locked) {
        while(input != "unlock") {
            Console.WriteLine($"The chest is {curState}. What do you want to do?");
            input = Console.ReadLine()!;
        }
        curState = Chest.closed;
        
    }
    else if (curState == Chest.closed){
        while(input != "open" && input != "lock"){
            Console.WriteLine($"The chest is {curState}. What do you want to do?");
            input = Console.ReadLine()!;
        }
        switch(input) {
            case "open":
                curState = Chest.open;
                break;
            case "lock":
                curState = Chest.locked;
                break;
            default:
                break;

        }
    }
    else if (curState == Chest.open) {
        while(input != "close"){
            Console.WriteLine($"The chest is {curState}. What do you want to do?");
            input = Console.ReadLine()!;
        }
        curState = Chest.closed;
    }


}

enum Chest {open , closed, locked}




