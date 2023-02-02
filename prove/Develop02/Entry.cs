using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Entry{
    // Has an attribute for the date, prompt and entry
    public String journalInput;
    PromptGenerator promptGenerator = new PromptGenerator();
    Journal journal = new Journal();
    public DateTime theCurrentTime = DateTime.Now;
    public string dateText;
    public string thePrompt;
    public void singleEntry(){
        journalInput = Console.ReadLine();
        Console.WriteLine("");
    }

    public void JournalEntry(){
        
        dateText = $"{theCurrentTime.ToShortDateString()}";
        thePrompt = $" - {promptGenerator.GetRandomQuestion()}";
        Console.Write(dateText);
        Console.WriteLine(thePrompt);
        Console.WriteLine(journalInput);
        journal._entries.Add($"{dateText} - {thePrompt} {journalInput}");

            // string theTime = date.ToShortDateString();
        }
    

}