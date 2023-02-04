using System;
using System.IO;
public class Journal{
    public List<object> _entries = new List<object>();
    //public string fileName;
    PromptGenerator _promptGenerator = new PromptGenerator();
    //public EntryClass entry = new EntryClass();
    String _prompt = "";
    public string _dateText;
    public string _thePrompt;
    DateTime theCurrentTime = DateTime.Now;
    String _lineInfoToSave = "";
    String _userEntry;
    //write an entry method
    public void Write (){
            _prompt = _promptGenerator.DisplayQuestion();
            _userEntry = Console.ReadLine();
    }
    //Display method
    public void Display(){
            
        _dateText = $"{theCurrentTime.ToShortDateString()}";
        _thePrompt = _prompt;
        _lineInfoToSave = $"{_dateText} - {_thePrompt}";
        Console.WriteLine(_lineInfoToSave);
        Console.WriteLine(_userEntry);

        //Console.Write(_dateText);
        //Console.WriteLine(_thePrompt);

            // string theTime = date.ToShortDateString();
    }

    //Save the entries method
    public void SaveData(String fileName)
        {


            using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    _entries.Add($"{_dateText} - {_thePrompt}");
                    _entries.Add($"{_userEntry}");
                    _entries.Add(",");
                    // You can add text to the file with the WriteLine method
                    for (int i = 0; i < _entries.Count; i++){
                        outputFile.WriteLine(_entries[i]);
                    }
                    // You can use the $ and include variables just like with Console.WriteLine
                    //string color = "Blue";
                    //outputFile.WriteLine($"My favorite color is {color}");
                }
        }

    //Read method

    public void ReadFile(String fileName){
;
        //string[] lines = System.IO.File.ReadAllLines(fileName);
//
        //foreach (string line in lines)
        //{
        //    string[] parts = line.Split(",");
        //
        //    string dateAndQuestion = parts[0];
        //    //string userAnswer = parts[1];
        //}
        string data;
        try {
            StreamReader reader = new StreamReader(fileName);
            data = reader.ReadLine();

            while (data != null)
            {
                Console.WriteLine(data);
                data = reader.ReadLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }


}
