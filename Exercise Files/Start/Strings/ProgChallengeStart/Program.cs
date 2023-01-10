using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            Boolean correct = false;
            int intGuess = 0;
            int guesses = 0;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            do
            {

                try
                {
                    Console.WriteLine("What's your guess?");
                    
                    var guess = Console.ReadLine();
                    guesses++;

                    if (!Int32.TryParse(guess, out intGuess))
                    {
                        throw new ArgumentOutOfRangeException("guess", "Only Numbers allowed");
                    }

                    if (intGuess == -1) {
                        Console.WriteLine($"Oh well, I was thinking of {theNumber}");
                        break;
                    }

                    if (intGuess > theNumber) {
                        Console.WriteLine("Nope, lower than that.");
                    }
                    else if (intGuess < theNumber) {
                        Console.WriteLine("Nope, higher than that.");
                    }
                    else {
                        correct = true;
                        Console.WriteLine($"You got it in {guesses} guesses!!");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine($"Operation failed: {e.Message}");
                    continue;
                }

            } while (!correct);


            // Keep track of the number of guesses and the current user guess

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer

        }
    }
}
