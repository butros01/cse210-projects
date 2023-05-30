public class Word
{
    private bool _hidden = false;
    private  string _word;

    // public Word(string word, bool hidden)
    // {
    //     _word = word;
    //     _hidden = hidden;
    // }

    public string GetWord()
    {
        return _word;
    }
    public bool GetHidden()
    {
        return _hidden;
    }
}