class BreathingActivity : Activity {
    public void BreathingTimer(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityTime);
        DateTime currentTime;
        do {
            Console.Write("Breathe in...");
            Counterback(4);
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