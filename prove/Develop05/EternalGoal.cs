public class EternalGoal : Goal
{

    // GoalTracker goalTracker = new GoalTracker();
    public EternalGoal(string name, int points) : base(name, points)
    {
        isComplete = false;
    }

    public override int RecordEvent(int count)
    {
        isComplete = true;
        return points;
    }

    // public void CreateEternalGoal(string name, int points)
    // {
    // EternalGoal goal = new EternalGoal(name, points);
    // goalTracker.GetGoals().Add(goal);
    // }
}