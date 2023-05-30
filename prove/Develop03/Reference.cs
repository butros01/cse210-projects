public class Reference
{
    private static string _book;
    private static int _chapter;
    private static int  _startVerse;
    private static int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
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
        if (_endVerse == 0)
        {
            string referenceText = $"{_book} {_chapter}:{_startVerse}";
            return referenceText;
        }
        else 
        {
            string referenceText = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
            return referenceText;
        }
        
        
    }
}

