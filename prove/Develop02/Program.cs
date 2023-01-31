using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry entry = new Entry();
        Journal journal = new Journal();

        DateTime date = new DateTime();
        string theDate = date.ToLongDateString();
        string theTime = date.ToShortDateString();


        int userEntry;
        String userEntryStr;
        do {
        promptGenerator.DisplayPrompts();    
        
        userEntryStr = Console.ReadLine();
        userEntry = Int32.Parse(userEntryStr);
        if (userEntry == 1)
            {
                entry.DisplayQuestion();
                journal.SaveEntries(entry.choseIndex, entry.JournalEntry());
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

                string newFileName = $"Journal_of{theDate}";
                //string path = @"D:\BYU-I\CSE210_2023\CSE210-2023\prove\Develop02";
                journal.SaveData(journal._entries, newFileName);
            }
        else if(userEntry == 5)
            {
                Console.WriteLine("Bye Bye");
            }
        } while (userEntry != 5);
    }
}