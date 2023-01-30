using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry entry = new Entry();
        Journal journal = new Journal();
        int userEntry;
        String userEntryStr;
        do {
        promptGenerator.DisplayPrompts();    
        
        userEntryStr = Console.ReadLine();
        userEntry = Int32.Parse(userEntryStr);
        if (userEntry == 1)
            {
                entry.DisplayQuestion();
                entry.SaveJournalEntry();
            }
        else if(userEntry == 2)
            {
                journal.DisplayEntries();
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
                Console.WriteLine("Bye Bye");
            }
        } while (userEntry != 5);
    }
}