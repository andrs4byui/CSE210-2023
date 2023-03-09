using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        SimpleGoal simpleGoal = new SimpleGoal();

        Console.WriteLine($"You have 0 points.");
        Console.WriteLine();
        goalManager.DisplayOptions();
        //Console.WriteLine($"This is the User option choice {goalManager._userOptionChoice}");
        
        //If the user wants to create a Goal
        if (goalManager._userOptionChoice == "1"){
            goalManager.DisplayGoalOptions();
            Console.WriteLine(goalManager._goalOptionChoice);
            if (goalManager._goalOptionChoice == "1"){
                simpleGoal.DisplayQuestions();
            }
            else {
                Console.WriteLine("Nothing here");
            }
        }
    }
}