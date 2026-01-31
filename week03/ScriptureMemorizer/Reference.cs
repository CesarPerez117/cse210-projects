using System.Security.Principal;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public string Book
    {
        get {return _book;}
        private set {_book = value;}
    }
    public int Chapter
    {
        get {return _chapter;}
        private set {_chapter = value;}
    }
    public int StartVerse
    {
        get{return _startVerse;}
        private set {_startVerse = value;}
    }
    public int? EndVerse
    {
        get{return _endVerse;}
        private set {_endVerse = value;}
    }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return EndVerse.HasValue 
        ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" 
        : $"{Book} {Chapter}:{StartVerse}";
    }


}