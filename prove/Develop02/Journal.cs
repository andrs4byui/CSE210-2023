using System;
using System.IO;
public class Journal{
    public List<object> _entries = new List<object>();
    //public string fileName;
    PromptGenerator promptGenerator = new PromptGenerator();
    //public EntryClass entry = new EntryClass();
    String prompt = "";
    public string _dateText;
    public string thePrompt;
    DateTime theCurrentTime = DateTime.Now;
    String lineInfoToSave = "";
    String userEntry;
    //write an entry method
    public void Write (){
            prompt = promptGenerator.DisplayQuestion();
            userEntry = Console.ReadLine();
    }
    //Display method
    public void Display(){
            
        _dateText = $"{theCurrentTime.ToShortDateString()}";
        thePrompt = prompt;
        lineInfoToSave = $"{_dateText} - {thePrompt}";
        Console.WriteLine(lineInfoToSave);
        Console.WriteLine(userEntry);

        //Console.Write(_dateText);
        //Console.WriteLine(thePrompt);

            // string theTime = date.ToShortDateString();
    }

    //Save the entries method
    public void SaveData(String fileName)
        {


            using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    _entries.Add($"{_dateText} - {thePrompt}");
                    _entries.Add($"{userEntry}");
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
