public  class Scripture
{
    private  static string _text;
    private static List <string> wordsInText;
    private static List<string> _words = new List <string>();
    private static string rF = Reference.GetReference();
    private List <int>_hiddenWords = new List<int>();
    public Scripture( string re, string text)
    {
        rF = re;
        _text = text;
    }
    public static string GetText()
    {
        return _text;
    }
    public static string GetReference()
    {
        return rF;
    }
    public List <string> GetWordsList()
    {
        wordsInText = _text.Split(" ").ToList();
        return wordsInText;
    }
    public string GetDisplayText()
    {
        return $"{GetReference()} {_text}";
    }
    public List <string> GetWords()
    {
        return _words;
    }

    public List <int> GetHiddenWords()
    {
        return _hiddenWords;
    }

    public void Display()
    {
        Console.WriteLine ($"{Scripture.GetReference()}  {string.Join(" ", GetWords())}");
    }
}



 

