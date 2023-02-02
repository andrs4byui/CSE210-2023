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
                promptGenerator.GetRandomQuestion();
                entry.singleEntry();
                journal.addEntryToJournal();
            }
        else if(userEntry == 2)
            {
                entry.JournalEntry();
            }
        else if(userEntry == 3)
            {
                Console.WriteLine("this is 3");
            }
        else if(userEntry == 4)
            {

                //string newFileName = $"Journal_of{theDate}";
                //string path = @"D:\BYU-I\CSE210_2023\CSE210-2023\prove\Develop02";
                journal.SaveData();
            }
        else if(userEntry == 5)
            {
                Console.WriteLine("Bye Bye");
            }
        else {
                Console.WriteLine("Please enter a valid option");
            }
        } while (userEntry != 5);
    }
}