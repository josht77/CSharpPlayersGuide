// See https://aka.ms/new-console-template for more information
TicTacToe ticTacToe = new TicTacToe();
ticTacToe.playGame();
public class TicTacToe
{
    public readonly string _screenTemplate;
    public char[] _board;
    private char _player1;
    private char _player2;
    private char _winner;
    private int _numOpenSpaces = 9;
    private bool _isPlayer1Turn = true;
    public void playGame()
    {
        DisplayDirections();
        assignPlayers();
        Console.WriteLine($"Player 1: {_player1}");
        Console.WriteLine($"Player 2: {_player2}");
        DisplayBoard();
        char possibleWinner = 'X';
        while (!hasWon(possibleWinner) && _numOpenSpaces > 0)
        {
            getCurrentTurn();
            getMove();
            DisplayBoard();
            possibleWinner = _isPlayer1Turn ? _player2 : _player1;
        }
        if (_numOpenSpaces == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It's a draw!!!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_winner} wins!!!!");
        }
    }
    public TicTacToe()
    {
        _board = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        _screenTemplate = File.ReadAllText("Board.txt");
    }
    private void DisplayBoard()
    {
        string board = _screenTemplate;
        for (int i = 0; i < this._board.Length; i++)
        {
            board = board.Replace($"{i + 1}", this._board[i].ToString());
        }
        Console.WriteLine(board);
    }
    private void DisplayDirections()
    {
        Console.WriteLine("Directions:");
        Console.WriteLine("Use your number keys(1-9) to select a postion to place your 'X' or 'O'.");
        Console.WriteLine("The numbers coorespond to locations on the board like this:");
        Console.WriteLine(_screenTemplate + "\n");
    }
    private void assignPlayers()
    {
        Console.WriteLine("What character do you want to play as 'X' or 'O'?");
        _player1 = char.ToUpper(char.Parse(Console.ReadLine()!));
        if (_player1 == 'X')
        {
            _player2 = 'O';
        }
        else
        {
            _player2 = 'X';
        }
    }
    private char getCurrentTurn()
    {
        string currentTurn = _isPlayer1Turn ? _player1.ToString() : _player2.ToString();
        Console.WriteLine($"It is {currentTurn}'s turn.");
        _isPlayer1Turn = !_isPlayer1Turn;
        return char.Parse(currentTurn);
    }
    private void getMove()
    {
        Console.WriteLine("What square do you want to play in?");
        int location = Convert.ToInt32(Console.ReadLine()!);
        while (!isValidMove(location))
        {
            Console.WriteLine("That square is already full.");
            Console.WriteLine("What square do you want to play in?");
            location = Convert.ToInt32(Console.ReadLine()!);
        }
        this._board[location - 1] = _isPlayer1Turn ? _player2 : _player1;
        _numOpenSpaces--;
    }
    private bool isValidMove(int move)
    {
        if (move > 9 || this._board[move - 1] != ' ')
        {
            return false;
        }
        return true;
    }
    private bool hasWon(char letter)
    {
        if (hasWonTopHorizontal(letter) ||
               hasWonMidHorizontal(letter) ||
               hasWonBottomHorizontal(letter) ||
               hasWonLeftVert(letter) ||
               hasWonMidVert(letter) ||
               hasWonRightVert(letter) ||
               hasWonDiagonalLeft(letter) ||
               hasWonDiagonalRight(letter))
        {
            this._winner = letter;
            return true;
        }
        else
        {
            return false;
        }
    }
    private bool hasWonTopHorizontal(char letter)
    {
        return this._board[0] == letter && this._board[1] == letter && this._board[2] == letter;
    }
    private bool hasWonMidHorizontal(char letter)
    {
        return this._board[3] == letter && this._board[4] == letter && this._board[5] == letter;
    }
    private bool hasWonBottomHorizontal(char letter)
    {
        return this._board[6] == letter && this._board[7] == letter && this._board[8] == letter;
    }
    private bool hasWonLeftVert(char letter)
    {
        return this._board[0] == letter && this._board[3] == letter && this._board[6] == letter;
    }
    private bool hasWonMidVert(char letter)
    {
        return this._board[1] == letter && this._board[4] == letter && this._board[7] == letter;
    }
    private bool hasWonRightVert(char letter)
    {
        return this._board[2] == letter && this._board[5] == letter && this._board[8] == letter;
    }
    private bool hasWonDiagonalLeft(char letter)
    {
        return this._board[0] == letter && this._board[4] == letter && this._board[8] == letter;
    }
    private bool hasWonDiagonalRight(char letter)
    {
        return this._board[2] == letter && this._board[4] == letter && this._board[6] == letter;
    }
}