public class SimpleGoal : Goal{
    public SimpleGoal(){
    }
    public SimpleGoal(string goalName, string goalDescription, int points, int goalawardedPoints) : base(points){
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = points;
        _goalawardedPoints = goalawardedPoints;
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
        _goalawardedPoints = int.Parse(Console.ReadLine());
        SetGoalPoints(_goalawardedPoints);
    }
}