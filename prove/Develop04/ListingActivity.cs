class ListingActivity : Activity {
    List<string> _listingPromptMessages = new List<string>();
    List<string> _userImputs = new List<string>();
    
    public ListingActivity(){
        _listingPromptMessages.Add("Who are people that you appreciate?");
        _listingPromptMessages.Add("What are personal strengths of yours?");
        _listingPromptMessages.Add("Who are people that you have helped this week?");
        _listingPromptMessages.Add("When have you felt the Holy Ghost this month?");
        _listingPromptMessages.Add("Who are some of your personal heroes?");
    }
    public void PromptMethod(int time) {
        Random random = new Random();
        int promptIndex = random.Next(_listingPromptMessages.Count);
        Console.WriteLine($"--- {_listingPromptMessages[promptIndex]} ---");
        Console.Write("You may begin in: ");
        Counterback(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime;
        do {
            Console.Write("> ");
            string userinput = Console.ReadLine();
            _userImputs.Add(userinput);
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);
    }
    public void DisplayNumberOfImputs() {
        
    }
}