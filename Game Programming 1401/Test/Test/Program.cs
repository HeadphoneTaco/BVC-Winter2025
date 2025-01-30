// See https://aka.ms/new-console-template for more information

// Generate a random number from 1 - 100
int randomNumber = new Random().Next(1, 101);

    bool playingGame = true;
    int numberOfGuesses = 0;
    int guessesRemaining = 10;



while (playingGame)
{
        
    
    
    
    // Ask the player to guess a number within this range
    Console.WriteLine("Guess a number between 1 - 100");
    guessesRemaining--;
    if (int.TryParse(Console.ReadLine(), out int guessedNumber))
    {
        // This was a valid number!
        
        Console.WriteLine($"You Guessed: {guessedNumber}");
        if (guessedNumber > randomNumber)
        {
            Console.WriteLine("You guessed too high!");
            CheckGuessesRemaining();
        }
        else if (guessedNumber < randomNumber)
        {
            Console.WriteLine("You guessed too low!");
            CheckGuessesRemaining();
        }
        else
        {
            Console.WriteLine($"You guessed correctly in {numberOfGuesses} guesses!");
            playingGame = false;
        }
        
        
    }
    else
    {
        //Was NOT a valid number
        Console.WriteLine("Not a valid number! \n Please enter a valid number!");
    }
    
}

void CheckGuessesRemaining()
{
    if (guessesRemaining == 0)
    {
        Console.WriteLine("Out of guesses!");
        playingGame = false;
    }
    else
    {
        Console.WriteLine($"You have {guessesRemaining} guesses left!");
    }
}
    
    
    
    
    // Display result of the number guess based on these conditions
    
    
    // IF correct, inform the player, end the game
        
        // IF incorrect, inform the player the number was higher or lower than the correct number
            // THEN loop back and get the player to guess again
    
    
    