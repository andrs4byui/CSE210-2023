public class Word {
    //Keeps track of a single word and whether it is shown or hidden.
    private string _wordString;
    private bool _isHidden;

    public Word(string wordString){
        _isHidden = false;
        _wordString = wordString;
    }

    public void Hide(){
        _wordString = new string('_', _wordString.Count());
        _isHidden = true;
    }
}
    //private string HideWord(){
    //    foreach (char c in Hide){
    //        _hide = "_";
    //        return _hide;
    //    }
    //}

}