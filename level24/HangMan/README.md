+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+ 
|                              |
|       HANGMAN OUTLINE        |
|                              |
+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+

1. list of words to pick from ("Words")
    - Can pick any word from that list at random 
2. Display status method
    - using instance variables
        - string "wordWithBlanks"
        - int "livesLeft"
        - List<char> "incorrectChars"
3. Game prompts the player:
    - to input a letter
4. update status method updates the state of the game given the player's input character
    - checks for letter in the word 
5. determine if game has been won at the end of each round
6. run program until game has been lost or won 
