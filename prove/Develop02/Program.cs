using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.DisplayPrompts();
            
        
        String userEntryStr;
        userEntryStr = Console.ReadLine();
        int userEntry = Int32. Parse(userEntryStr);
        Console.WriteLine(userEntry);
        Entry entry = new Entry();
        if (userEntry == 1)
            {
                Console.WriteLine("First Test");
                entry.DisplayQuestion();
            }
        else if(userEntry == 2)
            {
                Console.WriteLine("this is 2");
            }
        else if(userEntry == 3)
            {
                Console.WriteLine("this is 3");
            }
        else if(userEntry == 4)
            {
                Console.WriteLine("this is 4");
            }
        else if(userEntry == 5)
            {
                Console.WriteLine("this is 5");
            }
    }
}