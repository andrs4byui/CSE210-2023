using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Entry{
    // Has an attribute for the date, prompt and entry
    public String journalInput;
    
    public string dateText;
    public string thePrompt;
    DateTime theCurrentTime = DateTime.Now;
    PromptGenerator promptGenerator = new PromptGenerator();
    public void singleEntry(){
        journalInput = Console.ReadLine();
        Console.WriteLine("");
    }

    //Displays the last journal entry
    public void JournalEntry(String questionPrompt){
        dateText = $"{theCurrentTime.ToShortDateString()}";
        thePrompt = questionPrompt;
        Console.Write(dateText);
        Console.WriteLine(thePrompt);
        Console.WriteLine(journalInput);
        //journal._entries.Add($"{dateText} - {thePrompt} {journalInput}");

            // string theTime = date.ToShortDateString();
        }
    

}