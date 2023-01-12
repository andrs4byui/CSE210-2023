using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();


        static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the program!");
            };

        static void PromptUserName(String userName)
            {
                Console.Write("Please enter your name: ");
                userName = Console.ReadLine();
                return;
            };
        static void PropmtUserNumber(int favoriteNumber)
            {
                Console.Write("Please enter you favorite number: ");
                favoriteNumber = Console.Read();
            };
        static void SquareNumber();
            {
                Console.Write($"{userName} ");
            }


    }
}