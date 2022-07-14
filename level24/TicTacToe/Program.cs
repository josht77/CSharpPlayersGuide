// See https://aka.ms/new-console-template for more information

TicTacToe ttt = new TicTacToe();
ttt._board[0] = 'X';
ttt._board[8] = 'X';
ttt.playGame();
public class TicTacToe
{
    public readonly string _screenTemplate;
    public char[] _board;
    private char player1;
    private char player2;
    public void playGame() {
        DisplayBoard();
        // assignPlayers();
        
    }

    public TicTacToe() {
        _board = new char[9]{ ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
        _screenTemplate = File.ReadAllText("Board.txt");
    }

    private void DisplayBoard() {
        string board = _screenTemplate;
        for(int i = 0; i < this._board.Length; i++) {
            board = board.Replace($"{i+1}", this._board[i].ToString());
        }
        Console.WriteLine(board);
    }
    
}


