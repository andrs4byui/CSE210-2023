

public class PromptGenerator{

    Dictionary<string, int> options = new Dictionary<string, int>() {
        {"1. Write", 1},
        {"2. Display", 2},
        {"3. Load", 3},
        {"4. Save", 4},
        {"5. Quit", 5} 
    };


    public void DisplayPrompts()
        {
            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("******************************************");
            for (int i = 0; i < options.Count; i++)
                Console.WriteLine(options.ElementAt(i).Key, 
                options.ElementAt(i).Value);
            }
            

}