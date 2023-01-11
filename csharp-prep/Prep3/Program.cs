using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        String userNumberToGuess = Console.ReadLine();
        Console.Write("What is your guess? ");
        String userGuess = Console.ReadLine();

        int theNumber = int.Parse(userNumberToGuess);
        int theGuess = int.Parse(userGuess);

        if (theNumber == theGuess)
            {
                Console.WriteLine("You guessed it!");
            }
        else if (theNumber > theGuess)
            {
                Console.WriteLine("Higher");
            }
        else
            {
                Console.WriteLine("Lower");
            }
        ;   
    }
}