public class EternalGoal : Goal {
    public EternalGoal(){
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