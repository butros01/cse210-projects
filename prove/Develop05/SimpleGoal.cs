public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent(int count)
    {
        if (count == 1)
        {
            isComplete = true;
            return points;
        }
        else
        {
            return 0;
        }
    }
}