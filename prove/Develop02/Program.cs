using System;


class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int _userEntry;
        String _userEntryStr;
        String _fileName;
        do {
        promptGenerator.DisplayPrompts();    
        
        _userEntryStr = Console.ReadLine();
        _userEntry = Int32.Parse(_userEntryStr);
        
        if (_userEntry == 1)
            {
                journal.Write();
                //journal.addEntryToJournal();
            }
        else if(_userEntry == 2)
            {
                journal.Display();
            }
        else if(_userEntry == 3)
            {
                Console.Write("Enter the filename you want to read: ");
                _fileName = Console.ReadLine();
                journal.ReadFile(_fileName);
            }
        else if(_userEntry == 4)
            {
                //string newFileName = $"Journal_of{theDate}";
                //string path = @"D:\BYU-I\CSE210_2023\CSE210-2023\prove\Develop02";
                Console.WriteLine("Please enter your file name: ");
                _fileName = Console.ReadLine();
                journal.SaveData(_fileName);
            }
        else if(_userEntry == 5)
            {
                Console.WriteLine("Bye Bye");
            }
        else {
                Console.WriteLine($"{_userEntry} is not a valid option");
                Console.WriteLine("Please enter a valid option");
            }
        } while (_userEntry != 5);
    }
}