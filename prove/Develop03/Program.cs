using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string wordsOfScripture = "16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        //List<string> list = new List<string>();

        string[] splittedStringArray = wordsOfScripture.Split(' ');
        scripture.ScriptureText = wordsOfScripture;
        scripture.PopulateScripture();
        //scripture.List = scripture.ScriptureText.Split(' ').ToList();
        scripture.HideWords();


    }
}