class ReflectionActivity : Activity {

    List<string> reflectionPromptMessages = new List<string>();
    List<string> reflectionPromptQuestions = new List<string>();

    public ReflectionActivity(){
        reflectionPromptMessages.Add("Think of a time when you stood up for someone else.");
        reflectionPromptMessages.Add("Think of a time when you did something really difficult.");
        reflectionPromptMessages.Add("Think of a time when you helped someone in need.");
        reflectionPromptMessages.Add("Think of a time when you did something truly selfless.");
  

        reflectionPromptQuestions.Add("Why was this experience meaningful to you? ");
        reflectionPromptQuestions.Add("Have you ever done anything like this before? ");
        reflectionPromptQuestions.Add("How did you get started? ");
        reflectionPromptQuestions.Add("How did you feel when it was complete? ");
        reflectionPromptQuestions.Add("What made this time different than other times when you were not as successful? ");
        reflectionPromptQuestions.Add("What is your favorite thing about this experience? ");
        reflectionPromptQuestions.Add("What could you learn from this experience that applies to other situations? ");
        reflectionPromptQuestions.Add("What did you learn about yourself through this experience? ");
        reflectionPromptQuestions.Add("How can you keep this experience in mind in the future? ");
    }

    public void PromptMethod(){      
        Console.WriteLine("Consider the Following prompt:");
        Random random = new Random();
        int promptIndex = random.Next(reflectionPromptMessages.Count);
        Console.WriteLine($" --- {reflectionPromptMessages[promptIndex]} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        ConsoleKeyInfo userKey = Console.ReadKey();
        if (userKey.Key == ConsoleKey.Enter){
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        }
    }
    public void PonderActivity(int time){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime;
        do {
            for (int i = 0; i < reflectionPromptQuestions.Count ; i++){
            Console.Write($"{reflectionPromptQuestions[i]}");
            SpinningTime(5);
            Console.WriteLine("\b \b"); 
            }
            currentTime = DateTime.Now;
        } while (currentTime < futureTime); 
    }
}