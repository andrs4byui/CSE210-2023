public abstract class Goal {
    public string _goalTypeName;
    public string _goalName ;
    public string _goalDescription;
    protected int _goalPoints;
    public int _goalAwardedPoints;
    public int _goalTimesToComplete;
    public bool _isCompleted;
    public int _bonusPoints;
    public int _goalTimesCompleted;
    public int GetGoalPoints(){
        return _goalPoints;
    }
    public void SetGoalPoints(int goalPoints){
        _goalPoints = goalPoints;
    }
    public Goal(){
    
    }
    public Goal(int goalPoints){
        _goalPoints = goalPoints;
    }
    public Goal(string goalName, string goalDescription, int goalPoints){
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }
    public abstract void DisplayPoints();
    public abstract void DisplayQuestions();
}