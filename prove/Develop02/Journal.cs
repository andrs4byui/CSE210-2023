using System;
using System.IO;
public class Journal{
    public List<object> _entries = new List<object>();
    public string fileName;
    public Entry entry = new Entry();

    public void addEntryToJournal() {
        _entries.Add($"{entry.dateText}- {entry.thePrompt} {entry.journalInput}");
    }

    public void SaveData()
        {

            Console.WriteLine("Please enter your file name: ");
            fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    // You can add text to the file with the WriteLine method
                    for (int i = 0; i < _entries.Count; i++){
                        outputFile.WriteLine(_entries[i]);
                    }
                    // You can use the $ and include variables just like with Console.WriteLine
                    string color = "Blue";
                    outputFile.WriteLine($"My favorite color is {color}");
                }
        }

    //Read all the lines from the file. 

}
