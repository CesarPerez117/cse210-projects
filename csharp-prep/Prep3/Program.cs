using System;

class Program
{
    static void Main(string[] args)
    {
    
        int guessValue = -1;
        int numberValue = -2;
        int tries = 0;

        while (guessValue != numberValue)
        {
            Console.Write("What is the magic number? ");
            numberValue = int.Parse(Console.ReadLine());

            Console.Write("What is your guess? ");
            guessValue = int.Parse(Console.ReadLine());

            tries += 1;

            if (guessValue < numberValue)
            {
                Console.WriteLine("Higher");
            }
            else if (guessValue > numberValue)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You tried {tries} times.");
            }
        }

    }
}