public class Scripture{
    //Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

    Reference refernece = new Reference("Juan", 3, 16);
    //string[] words = {" 16", " For", " God", " so", " loved", " the", " world", "," , " that", " he", " gave", " his", " only", " begotten", " Son", ",", " that", " whosoever", " believeth", " in", " him", " should", " not", " perish", ",", " but", " have", " heverlasting", " life", "."}; 
    Random random = new Random();
    private string _scriptureText;
    public string ScriptureText { get => _scriptureText; set => _scriptureText = value; }
    public List<Word> _words = new List<Word>();
    public Scripture(){
        List<string> list = ScriptureText.Split(' ').ToList(); 
        for (int i = 0 ; i<list.Count(); i++){
            Word word = new Word(list[i]);
            _words.Add(word);
        }
    }
    public void PopulateScripture(){
        List<string> list = ScriptureText.Split(' ').ToList(); 

        Console.WriteLine();

    }

// while loop if words ar not hidden
    public void HideWords(){
        int randomIndex = random.Next(_words.Count);
        _words[randomIndex] = new string('_', list[randomIndex].Count());


        for (int i = 0 ; i<_words.Count(); i++){
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }


}
//This piece of code was helpful to change form a character to a "_" string
//string s = "fourwordsaretwenty";
//s = new string('*', s.Count());
//Console.WriteLine(s);
