public class Reference{
    //Keeps track of the book, chapter, and verse information.
    string _book;
    int _chapter;
    int _verse;
    int _endVerse;

    public Reference()
    {
        _book = "";
        _chapter = 1;
        _verse = 1;
        _endVerse = 1;
    }
    public Reference(String book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }

    public Reference(String book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
    }


}