public class ChecklistGoal : Goal{

    public ChecklistGoal(){
        _goalTypeName = "Checklist Goal";
    }
    public ChecklistGoal(string goalName, string goalDescription, int goalAwardedPoints, int bonusPoints,int goalTimesToComplete, int goalTimesCompleted){
        _goalTypeName = "Checklist Goal";
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalAwardedPoints = goalAwardedPoints;
        _bonusPoints = bonusPoints;
        _goalTimesToComplete = goalTimesToComplete;
        _goalTimesCompleted = goalTimesCompleted;
    }
    public override void DisplayPoints()
    {
        throw new NotImplementedException();
    }
    public override void DisplayQuestions(){
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _goalAwardedPoints = int.Parse(Console.ReadLine());
        SetGoalPoints(_goalAwardedPoints);

        Console.Write("how many times does this goal need to be accomplished for a bonus? ");
        _goalTimesToComplete = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints= int.Parse(Console.ReadLine());
    }
}