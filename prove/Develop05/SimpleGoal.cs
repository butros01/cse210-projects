public class SimpleGoal : Goal
{
    private int _count;
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _count = 0;
        _isComplete = isComplete;
        
    }

    public override int RecordEvent(int count)
    {
        _count += count;
        if (_count == 1)
        {
            _isComplete = true;
            return Points();
        }
        else
        {
            return 0;
        }
    }
}