

public class PromptGenerator{

    Dictionary<string, int> options = new Dictionary<string, int>() {
        {"Write", 1},
        {"Display", 2},
        {"Load", 3},
        {"Save", 4},
        {"Quit", 5} 
    };


    public void DisplayPrompts()
        {
            Console.WriteLine("Please select one of the following choices");
            for (int i = 0; i < options.Count; i++)
                Console.WriteLine(options.ElementAt(i).Key, 
                options.ElementAt(i).Value);
            }
            

}