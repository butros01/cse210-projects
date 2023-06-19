public class SimpleGoal : Goal
{
    private int value;

    // GoalTracker goalTracker = new GoalTracker();
    public SimpleGoal(string name, int value, int points) : base(name, points)
    {
        this.value = value;
    }

    public override int RecordEvent(int count)
    {
        if (count == value)
        {
            isComplete = true;
            return points;
        }
        else
        {
            return 0;
        }
    }

    // public void CreateSimpleGoal(string name, int value, int points)
    // {
    //     SimpleGoal goal = new SimpleGoal(name, value, points);
    //     goalTracker.GetGoals().Add(goal);
    // }
}