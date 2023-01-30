using System;
using System.Collections.Generic;
public class Entry{
    List<string> _questions = new List<string>();
    int _index;
    public String _journalInput;
    public String choseIndex; 
    public void DisplayQuestion(){
        
        _questions.Add("Who was the most interesting person I interacted with today?");
        _questions.Add("What was the best part of my day?");
        _questions.Add("How did I see the hand of the Lord in my life today?");
        _questions.Add("What was the strongest emotion I felt today?");
        _questions.Add("If I had one thing I could do over today, what would it be?");
        
        //Console.WriteLine("Test");
        Random random = new Random();
        _index = random.Next(_questions.Count);
        choseIndex = _questions[_index];
        Console.WriteLine(choseIndex);
  
    }
    public String JournalEntry(){
        _journalInput = Console.ReadLine();
        Console.WriteLine("");
        return _journalInput;
        }
}