using System;

public class Journal{
    public List<object> _entries = new List<object>();

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
            string path = "D:\BYU-I\CSE210_2023\CSE210-2023\prove\Develop02";
            //Console.WriteLine(applicationPath);
            string saveFilePath = Path.Combine(path, fileName);
            StreamWriter w = new StreamWriter(saveFilePath, true);
            w.WriteLine(contentToSave);
            w.Close();
        }
}