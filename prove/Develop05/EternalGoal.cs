public class EternalGoal : Goal
{

    // GoalTracker goalTracker = new GoalTracker();
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        isComplete = false;
    }

    public override int RecordEvent(int count)
    {
        isComplete = false;
        return points;
    }

    // public void CreateEternalGoal(string name, int points)
    // {
    // EternalGoal goal = new EternalGoal(name, points);
    // goalTracker.GetGoals().Add(goal);
    // }
}