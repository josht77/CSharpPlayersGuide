// See https://aka.ms/new-console-template for more information

TicTacToe ttt = new TicTacToe();
<<<<<<< HEAD
ttt._board[0] = 'X';
ttt._board[8] = 'X';
=======
Console.Clear();
ttt.board[0] = 'X';
>>>>>>> 64b60e8cc86047f49bb4f76a55777ab72880a51f
ttt.playGame();
public class TicTacToe
{
    public readonly string _screenTemplate;
    public char[] _board;
    private char player1;
    private char player2;
    private bool isPlayer1Turn = true;

    public void playGame() {
        DisplayDirections();
        getChar();
        getCurrentTurn();
        DisplayBoard();
        getMove();
        // assignPlayers();
        
    }

    public TicTacToe() {
        _board = new char[9]{ ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
        _screenTemplate = File.ReadAllText("Board.txt");
    }

    // ?????
    private void DisplayBoard() {
        string board = _screenTemplate;
        for(int i = 0; i < this._board.Length; i++) {
            board = board.Replace($"{i+1}", this._board[i].ToString());
        }
        Console.WriteLine(board);
    }



    private void DisplayDirections() {
        Console.WriteLine("Directions:");
        Console.WriteLine("Use your number keys(1-9) to select a postion to place your 'X' or 'O'.");
        Console.WriteLine("The numbers coorespond to locations on the board like this:");
        Console.WriteLine(_screenTemplate);
        // Console.Clear();
    }
    // Can we use Readkey or ReadLine? 
    private void getChar(){
        Console.WriteLine("What character do you want to play as 'X' or 'O'?");
        Console.ReadKey();
        // assign to player1 variable
    }

    private void getCurrentTurn() {
        string currentTurn = isPlayer1Turn ? "X" : "O";
        Console.WriteLine($"It is {currentTurn}'s turn.");
        isPlayer1Turn = !isPlayer1Turn;
    }

    private void getMove() {
        Console.WriteLine("What square do you want to play in?");
        int location = Convert.ToInt32(Console.ReadLine()!);
        while(!isValidMove(location)) {
            Console.WriteLine("That square is already full.");
            Console.WriteLine("What square do you want to play in?");
            location = Convert.ToInt32(Console.ReadLine()!);
        }
    }

    // how do I check if that spot is empty?
    private bool isValidMove(int move) {
        if(board[move] == ' ') {
            return true;
        }
        return false;
    }
    
    
    
}


