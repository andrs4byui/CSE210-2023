using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String theUserName = PromptUserName();
        int promptedNumber = PropmtUserNumber();
        int squaredNumber = SquareNumber(promptedNumber);
        Console.Write($"{theUserName}, the square of your number is {squaredNumber}");


        static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the program!");
            };

        static String PromptUserName()
            {
                Console.Write("Please enter your name: ");
                String userName = Console.ReadLine();
                return userName;
                };
        static int PropmtUserNumber()
            {
                Console.Write("Please enter you favorite number: ");
                String favoriteNumber = Console.ReadLine();
                return  int.Parse(favoriteNumber);
            };
        static int SquareNumber(int userNumber)
            {   
                int numberSquared = userNumber * userNumber;
                return numberSquared;

            }
    }
}