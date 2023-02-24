class BreathingActivity : Activity {
    private List<string> _breathingInstructions;

    public BreathingActivity(int activityTime) {
        _activityTime = activityTime;
    }
    public void breathingTimer(int time){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime;
        do {
            Console.Write("Breathe in...");
            BreatheCounterback(3);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            BreatheCounterback(6);
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("");
            currentTime = DateTime.Now;
        } while (currentTime < futureTime); 
    }

    private void BreatheCounterback(int CountFromNumberBackwards){
        for (int i = CountFromNumberBackwards; i > 0; i--){
        Console.Write($"{i}");
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the + character
        }
    }
}