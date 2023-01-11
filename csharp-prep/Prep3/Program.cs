using System;

class Program
{
    static void Main(string[] args)
    {
        int theNumber;
        int theGuess;
        do 
        {
        Console.Write("What is the magic number? ");
        String userNumberToGuess = Console.ReadLine();
        Console.Write("What is your guess? ");
        String userGuess = Console.ReadLine();

        theNumber = int.Parse(userNumberToGuess);
        theGuess = int.Parse(userGuess);

        if (theNumber > theGuess)
            {
                Console.WriteLine("Higher");
            }
        else if (theNumber < theGuess)
            {
                Console.WriteLine("Lower");
            }
        else 
            {
                Console.WriteLine("You guessed it");
            }
        } while (theGuess != theNumber);
    }
}