public class Scripture{
    //Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

    Reference refernece = new Reference("Juan", 3, 16);
    //string[] words = {" 16", " For", " God", " so", " loved", " the", " world", "," , " that", " he", " gave", " his", " only", " begotten", " Son", ",", " that", " whosoever", " believeth", " in", " him", " should", " not", " perish", ",", " but", " have", " heverlasting", " life", "."}; 
    Random random = new Random();
    private string _scriptureText;
    public string ScriptureText { get => _scriptureText; set => _scriptureText = value; }

    public void PopulateScripture(){
        List<string> list = ScriptureText.Split(' ').ToList(); 
        for (int i = 0 ; i<list.Count(); i++){
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();

    }

    public void HideWords(){
        List<string> list = ScriptureText.Split(' ').ToList(); 
        list[random.Next(list.Count)] = new string('_', list[random.Next(list.Count)].Count());

        
        for (int i = 0 ; i<list.Count(); i++){
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }
    public void RenderOutput(){
        HideWords();
    }


}
//This piece of code was helpful to change form a character to a "_" string
//string s = "fourwordsaretwenty";
//s = new string('*', s.Count());
//Console.WriteLine(s);
