using System;


class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int userEntry;
        String userEntryStr;

        do {
        promptGenerator.DisplayPrompts();    
        
        userEntryStr = Console.ReadLine();
        userEntry = Int32.Parse(userEntryStr);
        if (userEntry == 1)
            {
                journal.Write();
                //journal.addEntryToJournal();
            }
        else if(userEntry == 2)
            {
                journal.Display();
            }
        else if(userEntry == 3)
            {
                journal.ReadFile();
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
                Console.WriteLine($"{userEntry} is not a valid option");
                Console.WriteLine("Please enter a valid option");
            }
        } while (userEntry != 5);
    }
}