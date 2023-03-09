class GoalManager{
    public string _userOptionChoice;
    public string _goalOptionChoice;
    public void DisplayOptions(){
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3.Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
        _userOptionChoice = Console.ReadLine();
    }

    //When the user wants to create a new goal. 
    public void DisplayGoalOptions(){
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        Console.Write("Please enter your choice: ");
        _goalOptionChoice = Console.ReadLine();
    }
}