public class ChecklistGoal : Goal
{
    private int count;
    private int bonusThreshold;
    // GoalTracker goalTracker = new GoalTracker();

    public ChecklistGoal(string name, int bonusThreshold, int points) : base(name, points)
    {
        count = 0;
        this.bonusThreshold = bonusThreshold;
    }

    public int Count
    {
        get { return count; }
    }

    public int BonusThreshold
    {
        get { return bonusThreshold; }
    }

    public override int RecordEvent(int count)
    {
        this.count += count;

        if (this.count >= bonusThreshold)
        {
            isComplete = true;
            return points + 500;
        }
        else
        {
            return points;
        }
    }

    // public void CreateChecklistGoal()
    // {
    //     ChecklistGoal goal = new ChecklistGoal(name, bonusThreshold, points);
    //     goalTracker.GetGoals().Add(goal);
    // }
}