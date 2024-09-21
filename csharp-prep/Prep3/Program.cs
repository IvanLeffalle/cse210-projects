using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Try to find out the secret number ");


        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber = 0;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");

            }
        }

        Console.WriteLine("Congrats! You guessed the number!");
    }
}