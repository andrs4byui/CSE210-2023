using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();
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
                    NotAValidInput();
                }
            }
            else if (goalManager._userOptionChoice == "2"){
                goalManager.ListGoals();
            }
            else if (goalManager._userOptionChoice == "3"){
                goalManager.SaveGoals();
                Console.WriteLine("Your file was succesfully saved");
            }
            else if (goalManager._userOptionChoice == "4"){
                goalManager.LoadGoals();
            }
            else if (goalManager._userOptionChoice == "5"){
                goalManager.RecordEvent();
            }
            else if (goalManager._userOptionChoice == "6"){
                Console.WriteLine("Did you save your goal list? Y/N");
                string userSaveInput = Console.ReadLine();
                if (userSaveInput == "No" | userSaveInput == "N" | userSaveInput == "no" | userSaveInput == "n"){
                    Console.WriteLine("Are you sure to exit without saving?");
                    string userDecitionToSave = Console.ReadLine();
                    if (userDecitionToSave == "no"){
                        goalManager._userOptionChoice = "0";
                    }
                    else {
                        return;
                    }
                }
                else if (userSaveInput == "Yes" | userSaveInput == "Y" | userSaveInput == "yes" | userSaveInput == "y"){
                    return;
                }
            }
            else {
                NotAValidInput();        
            }
        } while (goalManager._userOptionChoice != "6");
        
        void NotAValidInput(){
            Console.WriteLine("This is not a valid input.");
            Console.WriteLine("Please insert a valid input");
        }
    }    
}