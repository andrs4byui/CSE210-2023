using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        string userinput = "";
        BreathingActivity breathingActivity = new BreathingActivity(4);
        
        string _activity1Name = "Breathing Activity";
        string _activity2Name = "Reflecting Activity";
        string _activity3Name = "Listing Activity";

        string _activity1Specifications = "This Activity Will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string _activity2Specifications = "This activity Will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string _activity3Specifications = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
        string _activiTimeMessage = "How long, in seconds, would you like for your session? ";
        do {
            activity.DisplayActivities();
            Console.Write("Select a choice from the menu: ");
            userinput = Console.ReadLine();

            if (userinput == "1"){
                Console.WriteLine($"Welcome to the {_activity1Name}");
                Console.WriteLine(_activity1Specifications);        
                Console.Write(_activiTimeMessage);        
                int userTimeImput = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Get Ready");
                activity.Spinning();
                breathingActivity.breathingTimer(userTimeImput);

            }
        } while (userinput != "4" );

    }
}