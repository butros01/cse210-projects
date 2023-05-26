public  class Scripture
{
    private static string _text;
    private static string rF = Reference.GetReference();

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
}



 

