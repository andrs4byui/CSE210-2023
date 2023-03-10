public class ChecklistGoal : Goal{

    public int _goalRepetition;
    public int _checkListBonus;

    public ChecklistGoal(){
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

        Console.Write("how many times does this goal need to be accomplished for a bonus? ");
        _goalRepetition = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _checkListBonus= int.Parse(Console.ReadLine());
        _checklistGoal = true;
    }
}