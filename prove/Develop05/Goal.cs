public abstract class Goal {

    protected string _goalName ;
    protected string _goalDescription;
    protected int _goalPoints;
    protected int _goalawardedPoints;
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



}