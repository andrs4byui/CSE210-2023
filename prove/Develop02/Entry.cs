using System;
using System.Collections.Generic;
public class Entry{
    List<string> entryList = new List<string>();
    
    public void DisplayQuestion(){
        
        entryList.Add("Who was the most interesting person I interacted with today?");
        entryList.Add("What was the best part of my day?");
        entryList.Add("How did I see the hand of the Lord in my life today?");
        entryList.Add("What was the strongest emotion I felt today?");
        entryList.Add("If I had one thing I could do over today, what would it be?");

        Console.WriteLine("Test");
        //Random random = new Random();
        //int index = random.Next(entryList.Count);
        //Console.WriteLine(index);
    }
}