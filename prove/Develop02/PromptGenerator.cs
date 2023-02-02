

public class PromptGenerator{

    Dictionary<string, int> options = new Dictionary<string, int>() {
        {"1. Write", 1},
        {"2. Display", 2},
        {"3. Load", 3},
        {"4. Save", 4},
        {"5. Quit", 5} 
    };
        // Attributes for the display questions method
    public Random random = new Random();
    public List<string> _questions = new List<string>();

    int index;
    public String choseIndex; 

    public void DisplayPrompts()
        {
            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("******************************************");
            for (int i = 0; i < options.Count; i++)
                Console.WriteLine(options.ElementAt(i).Key, 
                options.ElementAt(i).Value);
            
            Console.Write("What would you like to do? ");
            }
            
    public String GetRandomQuestion(){
        _questions.Add("Who was the most interesting person I interacted with today?");
        _questions.Add("What was the best part of my day?");
        _questions.Add("How did I see the hand of the Lord in my life today?");
        _questions.Add("What was the strongest emotion I felt today?");
        _questions.Add("If I had one thing I could do over today, what would it be?");
        choseIndex = _questions[index];
        index = random.Next(_questions.Count);
        Console.WriteLine(choseIndex);
        return choseIndex;
    }

    //public String DisplayQuestion(){
        
        //Console.WriteLine("Test");
        //String theQuestion = GetRandomQuestion();
        //Console.WriteLine($"{theQuestion}");
        //return theQuestion;
  
    //}    
}