class Activity {
    protected string _activityName;
    protected string _activitySpecifications;
    protected int _activityTime;
    protected string _finishMessage;

    public Activity(){
        _activityName = "";
        _activitySpecifications = "";
        _activityTime = 0;
        _finishMessage = "";
    }
    public Activity(string activityName, string activitySpecifications, int activityTime, string finsihMessage){
        _activityName = activityName;
        _activitySpecifications = activitySpecifications;
        _activityTime = activityTime;
        _finishMessage = finsihMessage;
    }

    protected void Timer(){
    }
    public void DisplayActivities(){
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activity");
        Console.WriteLine(" 4. Quit");
    }
    public void Spinning(){
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write(@"\");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write(@"-");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.WriteLine("");
    }
}