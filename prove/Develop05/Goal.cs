public abstract class Goal {
    public string _goalTypeName;
    public string _goalName ;
    public string _goalDescription;
    public int _goalAwardedPoints;
    public int _goalTimesToComplete;
    public bool _isCompleted;
    public int _bonusPoints;
    public int _goalTimesCompleted;
    
    public Goal(){
    }

    public Goal(string goalName, string goalDescription, int goalAwardedPoints){
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalAwardedPoints = goalAwardedPoints;
    }
    public abstract void DisplayPoints();
    public abstract void DisplayQuestions();
}