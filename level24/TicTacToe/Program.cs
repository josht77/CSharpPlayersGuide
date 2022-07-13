// See https://aka.ms/new-console-template for more information

TicTacToe ttt = new TicTacToe();
Console.WriteLine(ttt._screenTemplate);
Console.Clear();
ttt.board[0] = 'X';
ttt.playGame();
public class TicTacToe
{
    public readonly string _screenTemplate;
    public char[] board;
    private char player1;
    private char player2;
    public void playGame() {
        DisplayBoard();
        // assignPlayers();
        
    }

    public TicTacToe() {
        board = new char[9];
        _screenTemplate = File.ReadAllText("Board.txt");
    }

    private void DisplayBoard() {
        string board = _screenTemplate;
        // for(int i = 0; i < board.Length(); i++) {
            // replace 'i+1' with board[i]
            board = board.Replace("1", board[0].ToString());
            Console.WriteLine(board);
        // }
    }
    
}


