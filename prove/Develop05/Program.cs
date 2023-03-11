using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();

        //Console.WriteLine($"This is the User option choice {goalManager._userOptionChoice}");
        do {
            Console.WriteLine($"You have {goalManager._totalPoints} points.");
            Console.WriteLine();
            goalManager.DisplayOptions();

        //If the user wants to create a Goal
            if (goalManager._userOptionChoice == "1"){
                goalManager.DisplayGoalOptions();
                //Console.WriteLine(goalManager._goalOptionChoice);
                if (goalManager._goalOptionChoice == "1"){
                    simpleGoal.DisplayQuestions();
                    //Console.WriteLine(simpleGoal._goalName);
                    //Console.WriteLine(simpleGoal._goalDescription);
                    //Console.WriteLine(simpleGoal._goalawardedPoints);
                    goalManager._goals.Add(simpleGoal);
                }
                else if (goalManager._goalOptionChoice == "2"){
                    eternalGoal.DisplayQuestions();
                    goalManager._goals.Add(eternalGoal);
                }
                else if (goalManager._goalOptionChoice == "3"){
                    checklistGoal.DisplayQuestions();
                    goalManager._goals.Add(checklistGoal);
                }
                else {
                    Console.WriteLine("Nothing here");
                }
            }
            else if (goalManager._userOptionChoice == "2"){
                goalManager.ListGoals();
            }
            else if (goalManager._userOptionChoice == "3"){
                goalManager.SaveGoals();
            }
            else if (goalManager._userOptionChoice == "4"){
                goalManager.LoadGoals();
            }
            else {
                Console.WriteLine("This is not a valid input.");
                Console.WriteLine("Please insert a valid input");
            }
        } while (goalManager._userOptionChoice != "6");
    }
}