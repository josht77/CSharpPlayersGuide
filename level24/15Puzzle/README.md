+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+ 
|                              |
|      15-PUZZLE OUTLINE       |
|                              |
+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+
1. 2D array to represent the tile board
2. Move tile method 
    - ask the user what number tile they want to move 
    - then ask what direction they want to move it (up, down, left, right)
        - determine if this move is possible, if the move is not possible, reprompt the user until they give a valid move
    - alter the board to reflect this recent move  
3. Gamestate 
    - track the state of the board
    - when tiles slide
    - determine when its solved
    - track the move count 
    - track round count 
4. hasWon method
    - loops through the 2D array to check if they are in order, if not it returns false
    - will be called at the end of every move
5. generatePuzzle 
    - generate a random board at the start
    - loop through a 4x4 grid filling in the spots with a number between 1-15
    - one spot must be null
6. display method 
    - displays board along with some stats in a nice format

Answer to question: No the dessign would not need to change based on the size of the board. Maybe a little bit of alteration with the formatting but that is all we would need to do.