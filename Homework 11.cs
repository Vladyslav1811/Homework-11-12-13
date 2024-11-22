class Hangman
{
    static void Main()
    {
        string secretWord = "exit";
        char[] guessedWord = new string('_', secretWord.Length).ToCharArray();
        int attemptsLeft = 6;

        Console.WriteLine("Welcome! Try to guess the hidden word!");
        Console.WriteLine($"Number of letters in the word: {secretWord.Length}");
        Console.WriteLine($"Number of allowed wrong guesses: {attemptsLeft}");

        while (attemptsLeft > 0 && new string(guessedWord).Contains("_"))
        {
            Console.Write("\nEnter your letter: ");
            char guess = Console.ReadLine().ToLower()[0];

            if (secretWord.Contains(guess))
            {
                Console.Write($"This letter is in the word! Letter position(s): ");
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == guess)
                    {
                        guessedWord[i] = guess;
                        Console.Write($"{i + 1} ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                attemptsLeft--;
                Console.WriteLine($"This letter is not in the word! Attempts left: {attemptsLeft}");
            }
        }
        if (!new string(guessedWord).Contains("_"))
        {
            Console.WriteLine($"\nCongratulations, you guessed the word! The hidden word was: {secretWord}.");
        }
        else
        {
            Console.WriteLine($"\nSorry, you lost. The hidden word was: {secretWord}.");
        }

        Console.WriteLine("Thanks for playing.");
    }
}