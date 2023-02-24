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
    public Activity(string activityName, string activitySpecifications, string timePrompt){
        _activityName = activityName;
        _activitySpecifications = activitySpecifications;
        //_finishMessage = finsihMessage;
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine(_activitySpecifications);        
        Console.WriteLine();
        Console.Write(timePrompt); 
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
        Console.Write("\b \b"); 
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write(@"\");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write(@"-");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
    }
    public void SpinningTime(int time){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime;
        do {
            Spinning();
            currentTime = DateTime.Now;
        } while(currentTime < futureTime);
    }
    public void Counterback(int CountFromNumberBackwards){
        for (int i = CountFromNumberBackwards; i > 0; i--){
        Console.Write($"{i}");
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the + character
        }
    }
}