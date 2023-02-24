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
            Counterback(3);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            Counterback(6);
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("");
            currentTime = DateTime.Now;
        } while (currentTime < futureTime); 
    }


}