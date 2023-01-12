using System;

class Program
{
    static void Main(string[] args)
    {
        int theNumber;
        int theGuess;

        //strech challenge Variables
        int numberOfGuess = 1;

        
        Boolean isPlaying = true;
        String playerWantsToPlay = "";

        while (isPlaying == true) 
            {
                Random randomGenerator = new Random();
                theNumber = randomGenerator.Next(1,100);

                Console.WriteLine("Guess the magic number!!");
            do 
            {

            Console.Write("What is your guess? ");
            String userGuess = Console.ReadLine();

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
                    Console.WriteLine($"Your intents to guess were {numberOfGuess}");

                };

            numberOfGuess += 1;

            } while (theGuess != theNumber);
            
            // Strech challenge
            Console.Write("Do you want to play again? ");
            playerWantsToPlay = Console.ReadLine();
            if (playerWantsToPlay == "Yes")
                {
                    isPlaying = true;
                }
            else 
                {
                    isPlaying = false;
                    Console.WriteLine("Thank you for playing");
                }
        
        }
    }
}