

public class PromptGenerator{

    Dictionary<string, int> _options = new Dictionary<string, int>() {
        {"1. Write", 1},
        {"2. Display", 2},
        {"3. Load", 3},
        {"4. Save", 4},
        {"5. Quit", 5} 
    };
        // Attributes for the display questions method
    public List<string> _questions = new List<string>();

    int _index;
    public String _choseIndex; 

    public void DisplayPrompts()
        {
            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("******************************************");
            for (int i = 0; i < _options.Count; i++)
                Console.WriteLine(_options.ElementAt(i).Key, 
                _options.ElementAt(i).Value);
            
            Console.Write("What would you like to do? ");
            }
            
    public String GetRandomQuestion(){
        Random random = new Random();
        _questions.Add("Who was the most interesting person I interacted with today?");
        _questions.Add("What was the best part of my day?");
        _questions.Add("How did I see the hand of the Lord in my life today?");
        _questions.Add("What was the strongest emotion I felt today?");
        _questions.Add("If I had one thing I could do over today, what would it be?");
        _index = random.Next(_questions.Count);
        _choseIndex = _questions[_index];
        //Console.WriteLine(choseIndex);
        return _choseIndex;
    }

    public String DisplayQuestion(){
        
        //Console.WriteLine("Test");
        String theQuestion = GetRandomQuestion();
        Console.WriteLine($"{theQuestion}");
        return theQuestion;
  
    }    
}