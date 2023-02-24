using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        string userinput = "";
        BreathingActivity breathingActivity = new BreathingActivity(4);
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        string _activity1Name = "Breathing Activity";
        string _activity2Name = "Reflecting Activity";
        string _activity3Name = "Listing Activity";

        string _activity1Specifications = "This Activity Will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string _activity2Specifications = "This activity Will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string _activity3Specifications = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
        string _activityTimeMessage = "How long, in seconds, would you like for your session? ";
        
        
        do {
            activity.DisplayActivities();
            Console.Write("Select a choice from the menu: ");
            userinput = Console.ReadLine();

            if (userinput == "1"){
                Activity activity1 = new Activity(_activity1Name, _activity1Specifications, _activityTimeMessage);
                int userTimeImput = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Get Ready");
                activity.SpinningTime(6);
                Console.WriteLine("");
                breathingActivity.breathingTimer(userTimeImput);
                Console.WriteLine("Well done!!");
                Console.WriteLine($"You have completed another {userTimeImput} seconds of the Breathing Activity.");
            }
            else if (userinput == "2"){
                Activity activity2 = new Activity(_activity2Name, _activity2Specifications, _activityTimeMessage);
                int userTimeImput = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Get Ready");
                activity.SpinningTime(6);
                Console.WriteLine("");
                reflectionActivity.PromptMethod();
                Console.Write("You may begin in: ");
                activity.Counterback(3);
                Console.WriteLine("");
                reflectionActivity.PonderActivity(userTimeImput);
                Console.WriteLine("Well done!!");
                Console.WriteLine($"You have completed another {userTimeImput} seconds of the Breathing Activity.");
                activity.SpinningTime(3);
                }
            else if (userinput == "3"){
                Activity activity3 = new Activity(_activity3Name, _activity3Specifications, _activityTimeMessage);
                int userTimeImput = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Get Ready");
                activity.SpinningTime(6);
                Console.WriteLine("");
                listingActivity.PromptMethod(userTimeImput);}
            else {
                Console.WriteLine("!!!This is not a valid input.!!!");
                Console.WriteLine("Please choose one of the following options.");
                Console.WriteLine("");
            }
        } while (userinput != "4" );

    }
}