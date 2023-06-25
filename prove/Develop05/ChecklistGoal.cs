public class ChecklistGoal : Goal
{
    private int _count;
    private int _bonusThreshold;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int bonusThreshold, int count) : base(name, description, points)
    {
        count = 0;
        this._bonusThreshold = bonusThreshold;
        this._bonusPoints = bonusPoints;
    }

    public int Count()
    {
        return _count; 
    }

    public int BonusThreshold()
    {
        return _bonusThreshold;
    }
    public int BonusPoints()
    {
        return _bonusPoints; 
    }

    public override int RecordEvent(int count)
    {
        this._count += count;

        if (this._count >= _bonusThreshold)
        {
            _isComplete = true;
            return Points() + _bonusPoints;
        }
        else
        {
            return Points();
        }
    }
}