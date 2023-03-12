public class SimpleGoal : Goal{
    public SimpleGoal(){
        _goalTypeName = "Simple Goal";
    }
    public SimpleGoal(string goalName, string goalDescription, int goalawardedPoints, bool isCompleted){
        _goalTypeName = "Simple Goal";
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalAwardedPoints = goalawardedPoints;
        _isCompleted = isCompleted;
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
        //SetGoalPoints(_goalAwardedPoints);
    }

}