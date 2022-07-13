// See https://aka.ms/new-console-template for more information

Console.WriteLine("Set Passcode: ");
Door door = new Door(Convert.ToInt32(Console.ReadLine()!));
while (true)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("Open, Close, Lock, Unlock, or Change Passcode");
    switch (Console.ReadLine()!.ToLower())
    {
        case "open":
            door.Open();
            break;
        case "close":
            door.Close();
            break;
        case "lock":
            door.Lock();
            break;
        case "unlock":
            door.Unlock();
            break;
        case "change passcode":
            door.changePasscode();
            break;
        default:
            break;

    }
}

public class Door
{
    private State state { get; set; }
    private int _passcode; 

    public Door(int passcode)
    {
        this._passcode = passcode;
    }


    public void Open()
    {
        if (this.state == State.Closed)
        {
            this.state = State.Open;
        }
        else
        {
            Console.WriteLine("The door must be closed to open it.");
        }
    }

    public void Close()
    {
        if (this.state == State.Open)
        {
            this.state = State.Closed;
        }
        else
        {
            Console.WriteLine("The door must be open to close it.");
        }
    }

    public void Lock()
    {
        if (this.state == State.Closed)
        {
            this.state = State.Locked;
        }
        else
        {
            Console.WriteLine("The door must be closed to lock it");
        }
    }

    public void Unlock()
    {
        validateInput();
        if (this.state == State.Locked)
        {
            this.state = State.Closed;
        }
        else
        {
            Console.WriteLine("The door must be locked to unlocked it. You must have the correct passcode.");
        }
    }

    public void changePasscode()
    {
        validateInput();
        Console.WriteLine("New passcode: ");
        this._passcode = Convert.ToInt32(Console.ReadLine()!);
    }

    private void validateInput()
    {
        Console.WriteLine("Input current passcode: ");
        int input = Convert.ToInt32(Console.ReadLine()!);
        while (input != _passcode)
        {
            Console.WriteLine("Try again: ");
            input = Convert.ToInt32(Console.ReadLine()!);
        }
    }
}



public enum State { Open, Closed, Locked }