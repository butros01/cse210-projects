public class Entry
{
    public string _date;
    public string _prompt;
    public string _reply;

    public string completeEntry()
    {
        string fullEntry = ($"Date: {_date} - {_prompt}\n{_reply}");
        return fullEntry;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_prompt}\n{_reply}");
        
    }
}

