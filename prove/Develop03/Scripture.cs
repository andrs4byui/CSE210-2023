public class Scripture{
    //Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    //string[] words = {" 16", " For", " God", " so", " loved", " the", " world", "," , " that", " he", " gave", " his", " only", " begotten", " Son", ",", " that", " whosoever", " believeth", " in", " him", " should", " not", " perish", ",", " but", " have", " heverlasting", " life", "."}; 
    Random random = new Random();
    private string _scriptureText;
    public string ScriptureText { get => _scriptureText; set => _scriptureText = value; }

    private List<Word> _words = new List<Word>();
    public List<Word> Words { get => _words; set => _words = value; }

    private int _countertoMemorize = 0;
    public int CountertoMemorize { get => _countertoMemorize; set => _countertoMemorize = value; }

    public void addScriptureObjects(){
        //List = ScriptureText.Split(' ').ToList(); 
        List<string> List = ScriptureText.Split(' ').ToList(); 
        for (int i = 0 ; i<List.Count(); i++){
            Word word = new Word(List[i]);
            _words.Add(word);
        }
    }
    public void DisplayScripture(){
        for (int i = 0 ; i<Words.Count(); i++){
            Console.Write(Words[i].WordString + " ");
        }
        Console.WriteLine();

    }

// while loop if words ar not hidden
    public void HideWords(){
        int counter = 0;
        while (counter < 3){
        int randomIndex = random.Next(Words.Count);
            for (int i = 0 ; i<Words.Count(); i++){
                if (i == randomIndex && Words[i].IsHidden != true){
                    Words[i].Hide();
                    counter++;
                }
            }
        }
    }
    public void checkScriptureEmpty(int counterToMemorize){
        for (int i = 0 ; i<Words.Count(); i++){
            if (Words[i].IsHidden == true){
                counterToMemorize++;
            }
        }

    }
}

