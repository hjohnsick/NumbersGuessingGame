using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts, secret_number, guess;
            Random Rnd = new Random(Guid.NewGuid().GetHashCode());

            secret_number = Rnd.Next(1, 101);

            attempts = 1;

            Console.WriteLine("Enter a guess: ");
            guess = int.Parse(Console.ReadLine());
            while (guess != secret_number)
            {
                if(guess > secret_number)
                {
                    Console.WriteLine("Your guess is bigger than my secret number.");
                }
                else
                {
                    Console.WriteLine("Your guess is smaller than my secret number.");
                }
                attempts += 1;

                Console.WriteLine("Try again!  Enter a guess: ");
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You found it!");
            Console.WriteLine("Attempts: " + attempts);
        }
    }
}
