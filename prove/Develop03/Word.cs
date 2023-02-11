public class Word {
    //Keeps track of a single word and whether it is shown or hidden.
    private string _wordString;
    private bool _isHidden;
    public string WordString { get => _wordString; set => _wordString = value; }
    public bool IsHidden { get => _isHidden; set => _isHidden = value; }

    public Word(string wordString){
        IsHidden = false;
        WordString = wordString;
    }


    public void Hide(){
        WordString = new string('_', WordString.Count());
        IsHidden = true;
    }
}
//This piece of code was helpful to change form a character to a "_" string
//string s = "fourwordsaretwenty";
//s = new string('*', s.Count());
//Console.WriteLine(s);
