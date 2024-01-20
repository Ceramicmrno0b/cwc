using System;

class Program
{
    
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        int numberGuess = 0;

        while (numberGuess != randomNumber){
            Console.Write("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine());
            if (randomNumber > numberGuess)
            {
                Console.WriteLine("Too low, my number is higher than that.");
            }
            else if (randomNumber < numberGuess)
            {
                Console.WriteLine("Too high, my number is lower than that.");
            }
            else
            {
                Console.WriteLine("Wow, you got it!");
            }
        }

    }
}