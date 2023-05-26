public class Reference
{
    public static string _book;
    public static int _chapter;
    public static int  _startVerse;
    public static int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        // if (_startVerse != _endVerse)
        // {
        //     _endVerse = ' ';
        // }
            
        
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

    public static string GetReference()
    {
        string referenceText = $"{_book} {_chapter}:{_startVerse}";
        return referenceText;
    }
}

