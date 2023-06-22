public class ChecklistGoal : Goal
{
    private int count;
    private int bonusThreshold;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int bonusThreshold, int bonusPoints, int points) : base(name, description, points)
    {
        count = 0;
        this.bonusThreshold = bonusThreshold;
        this.bonusPoints = bonusPoints;
    }

    public int Count()
    {
        return count; 
    }

    public int BonusThreshold()
    {
        return bonusThreshold;
    }
    public int BonusPoints()
    {
        return bonusPoints; 
    }

    public override int RecordEvent(int count)
    {
        this.count += count;

        if (this.count >= bonusThreshold)
        {
            isComplete = true;
            return Points() + bonusPoints;
        }
        else
        {
            return Points();
        }
    }
}