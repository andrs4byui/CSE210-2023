using System;
using System.IO;
public class Journal{
    public List<object> _entries = new List<object>();
    string fileName;
    public void SaveEntries(String theQuestion, String theEntry){
        _entries.Add(theQuestion);
        _entries.Add(theEntry);
    }
    public void DisplayEntries(){
        Console.WriteLine("=========================");
        for(int i=0;i<_entries.Count;i++)
            {
            Console.WriteLine(_entries[i]);
            }
    }

    public void SaveData(List<object> contentToSave , string fileName)
        {
            //string applicationPath = Path.GetFullPath(System.AppDomain.CurrentDomain.BaseDirectory); // the directory that your program is installed in
            //var path = "D:\BYU-I\CSE210_2023\CSE210-2023\prove\Develop02";
            //Console.WriteLine(applicationPath);
            //string saveFilePath = Path.Combine("D:\BYU-I\CSE210_2023\CSE210-2023\prove\Develop02", fileName);
            //StreamWriter w = new StreamWriter(saveFilePath, true);
            //w.WriteLine(contentToSave);
            //w.Close();
        
            string fileName = "myFile.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
                {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");

                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Blue";
                outputFile.WriteLine($"My favorite color is {color}");
                }
        }

    
}