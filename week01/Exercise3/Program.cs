using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        do
        {
            int guess;
            int guessCount = 0;
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

            do
            {
                Console.Write("Guess Number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took {guessCount} guesses.");
                }

            } while (number != guess);

            Console.Write("Play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");
        
        Console.WriteLine("Thanks for playing!");
    }
}