public class GoalManager{
    public string _userOptionChoice;
    public string _goalOptionChoice;
    public List<Goal> _goals = new List<Goal>();
    string _goalInformation;
    public int _totalPoints = 0;
    public void DisplayOptions(){
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
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

    public void ListGoals(){
        Console.WriteLine("The goals are");
        for (int i = 0; i < _goals.Count(); i++){
            if (_goals[i]._goalTypeName == "Simple Goal"){
                if(_goals[i]._isCompleted == true){
                _goalInformation = $"{i + 1}. [X] {_goals[i]._goalName} ({_goals[i]._goalDescription})";
                Console.WriteLine(_goalInformation);
                }
                else if (_goals[i]._isCompleted == false) {
                _goalInformation = $"{i + 1}. [ ] {_goals[i]._goalName} ({_goals[i]._goalDescription})";
                Console.WriteLine(_goalInformation);
                }
            }
            else if (_goals[i]._goalTypeName == "Eternal Goal"){
                _goalInformation = $"{i + 1}. [ ] {_goals[i]._goalName} ({_goals[i]._goalDescription})";
                Console.WriteLine(_goalInformation);
            }

            else if (_goals[i]._goalTypeName == "Checklist Goal") {
                //ChecklistGoal checklistGoal = _goals[i];
                _goalInformation = $"{i + 1}. [ ] {_goals[i]._goalName} ({_goals[i]._goalDescription}) -- Currently completed {_goals[i]._goalTimesCompleted}/{_goals[i]._goalTimesToComplete}";
                Console.WriteLine(_goalInformation);
                }
        }
    }

    public void SaveGoals(){
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            outputFile.WriteLine(_totalPoints);
            for (int i = 0; i < _goals.Count(); i++){
                if (_goals[i]._goalTypeName == "Simple Goal"){
                    _goalInformation = $"{_goals[i]._goalTypeName}:{_goals[i]._goalName},{_goals[i]._goalDescription},{_goals[i]._goalAwardedPoints},{_goals[i]._isCompleted}";
                    outputFile.WriteLine(_goalInformation);
                    }
                else if (_goals[i]._goalTypeName == "Eternal Goal"){
                    _goalInformation = $"{_goals[i]._goalTypeName}:{_goals[i]._goalName},{_goals[i]._goalDescription},{_goals[i]._goalAwardedPoints}";
                    outputFile.WriteLine(_goalInformation);
                }
                else if (_goals[i]._goalTypeName == "Checklist Goal") {
                    _goalInformation = $"{_goals[i]._goalTypeName}:{_goals[i]._goalName},{_goals[i]._goalDescription},{_goals[i]._goalAwardedPoints},{_goals[i]._bonusPoints},{_goals[i]._goalTimesToComplete},{_goals[i]._isCompleted}";
                    outputFile.WriteLine(_goalInformation);
                }
            }
        }
    }

    public void LoadGoals(){
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        for (int i = 0; i < lines.Count(); i++){
            if(i == 0){
                _totalPoints = int.Parse(lines[i]); 
            }
            else{
                string[] parts = lines[i].Split(":");
                string goalTypeName = parts[0];
                string[] goalContent = parts[1].Split(",");
                //Console.WriteLine(goalContent);
                if(goalTypeName == "Simple Goal"){
                    SimpleGoal simpleGoal = new SimpleGoal(goalContent[0], goalContent[1], int.Parse(goalContent[2]), bool.Parse(goalContent[3]));
                    _goals.Add(simpleGoal);
                }
                else if(goalTypeName == "Eternal Goal"){
                    EternalGoal eternalGoal = new EternalGoal(goalContent[0], goalContent[1], int.Parse(goalContent[2]));
                    _goals.Add(eternalGoal);
                }
                else if(goalTypeName == "Checklist Goal"){
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalContent[0], goalContent[1], int.Parse(goalContent[2]), int.Parse(goalContent[3]), int.Parse(goalContent[4]), int.Parse(goalContent[5]));
                    _goals.Add(checklistGoal);
                }
            }
        }
    }
    public void RecordEvent(){
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count(); i++){
            int numberOfIndex = 1;
            Console.WriteLine($"{numberOfIndex + i}. {_goals[i]._goalName}");
        }
        Console.WriteLine("Which goal did you acomplish? ");
        int userInput = int.Parse(Console.ReadLine());
        for (int i = 0; i < _goals.Count(); i++){
            if (i == userInput - 1){
                _goals[i]._isCompleted = true;
                _totalPoints += _goals[i]._goalAwardedPoints;
            }
        }
        Console.WriteLine($"You now have {_totalPoints} point");
    }
    
}