public abstract class Goal
{
    private string _name;
    protected bool _isComplete;
    private int _points;
    private string _description;

    public Goal(string name, string description, int points)
    {
        this._name = name;
        this._description =description;
        this._points = points;
        _isComplete = false;
    }

    public string Name()
    {
        return _name;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public int Points()
    {
        return _points;
    }
    public string Description()
    {
        return _description;
    }

    public abstract int RecordEvent(int count);
};