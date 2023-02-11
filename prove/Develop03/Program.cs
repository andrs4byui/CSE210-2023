using System;

class Program
{
    static void Main(string[] args)
    {
        //Reference refernece = new Reference("Juan", 3, 16);
        Scripture scripture = new Scripture();
        string wordsOfScripture = "16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        //List<string> list = new List<string>();

        //string[] splittedStringArray = wordsOfScripture.Split(' ');
        scripture.ScriptureText = wordsOfScripture;
        //scripture.PopulateScripture();
        //scripture.List = scripture.ScriptureText.Split(' ').ToList();
        
        
        scripture.addScriptureObjects();
        //scripture.DisplayScripture();
        int counterCheck = 0;
        string input = "";
        do {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please Enter to continue or 'Quit' to finish:");
            input = Console.ReadLine();
            if(input == ""){
                Reference refernece = new Reference("Juan", 3, 16);
                scripture.DisplayScripture();
                scripture.HideWords();
                scripture.checkScriptureEmpty(counterCheck);
            }
        } while (counterCheck < scripture.Words.Count() & input != "Quit");
    }
}