using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        String userGrade = Console.ReadLine();

        int userGradeNumber = int.Parse(userGrade);


        if (userGradeNumber >= 90)
            {
                Console.WriteLine("You got an A");
            }
        else if (userGradeNumber >= 80)
            {
                Console.WriteLine("You got an B");
            }
        else if (userGradeNumber >= 70)
            {
                Console.WriteLine("You got an C");
            }
        else if (userGradeNumber >= 60)
            {
                Console.WriteLine("You got an D");
            }
        else
            {
                Console.WriteLine("You got an F");
            };    
        if (userGradeNumber > 70)
            {
                Console.WriteLine("Congratulations!! You Have passed the course.");
            }
        else 
            {
                Console.WriteLine("Sorry! You did not passed the course. Good luck for next time.");
            }
        
    }
}