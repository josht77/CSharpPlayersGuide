+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+ 
|                              |
|      TIC-TAC-TOE OUTLINE     |
|                              |
+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+

Instance variables:
1. int spotsLeft
    - everytime someone moves: spotsLeft--
2. char[] board 
    - indices reflect the 1-9
-------------
| 1 | 2 | 3 |
|-----------|
| 4 | 5 | 6 |
|-----------|
| 7 | 8 | 9 |
-------------

-------------
| 0 | 1 | 2 |
|-----------|
| 3 | 4 | 5 |
|-----------|
| 6 | 7 | 8 |
-------------
hasWon 

1. Display a tic-tac-toe board with the numbers 
2. Assigning x's or o's to players 
3. displayBoard()
    - make a 1D array to display the board
    - Can say a number 1-9 to place your symbol
4. getMove(int num)
    - prompt user using a while loop until they give a validate move
5. validateMove()
    - checks if that index in the array is not full
    - to be called in getMove
5. hasWon(char ch)
    - ch is the player's letter assignment
    - returns true if they won, false otherwise

QUESTION: Make a for loop for the games. Track stats (counter that says how many times each player has won). Alternate which player goes first each game.