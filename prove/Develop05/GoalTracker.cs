public class GoalTracker
{
    private List<Goal> goals;
    private int score;

    public GoalTracker()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public int Score
    {
        get { return score; }
    }

    public void CreateSimpleGoal(string name, int value, int points)
    {
        SimpleGoal goal = new SimpleGoal(name, value, points);
        goals.Add(goal);
    }

    public void CreateEternalGoal(string name, int points)
    {
        EternalGoal goal = new EternalGoal(name, points);
        goals.Add(goal);
    }

    public void CreateChecklistGoal(string name, int bonusThreshold, int points)
    {
        ChecklistGoal goal = new ChecklistGoal(name, bonusThreshold, points);
        goals.Add(goal);
    }

    

    public bool RecordEvent(string name, int count)
    {
        foreach (Goal goal in goals)
        {
            if (goal.Name.ToLower() == name.ToLower())
            {
                if (goal is SimpleGoal)
                {
                    SimpleGoal simpleGoal = (SimpleGoal)goal;
                    score += simpleGoal.RecordEvent(count);
                    return true;
                }
                else if (goal is EternalGoal)
                {
                    EternalGoal eternalGoal = (EternalGoal)goal;
                    score += eternalGoal.RecordEvent(count);
                    return true;
                }
                else if (goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    score += checklistGoal.RecordEvent(count);
                    return true;
                }
            }
        }

        return false;
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.Write($"[{(goal.IsComplete ? "X" : " ")}] {goal.Name}");

            if (goal is ChecklistGoal)
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                Console.WriteLine($" (Completed {checklistGoal.Count}/{checklistGoal.BonusThreshold} times)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }

    public void Save()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outPutFile = new StreamWriter(fileName, true))
        {
            foreach ( Goal line in goals)
            {
                outPutFile.WriteLine(line);
            }
        }
    }

    public void Load()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        string [] lines= File.ReadAllLines(fileName);

        foreach (string line in lines)

        {
            Console.WriteLine(line);
        }
    }

    public void CreatNewGoal()
    {
         Console.WriteLine($"The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist goal");
        Console.Write("What type of goal would you like to create? (1/2/3): ");
        int goalType = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the name of the goal?");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());

        switch(goalType)
        {
            case 1:
            {
                Console.WriteLine("What is the value of this goal?");
                int value = int.Parse(Console.ReadLine());
                CreateSimpleGoal(goalName, value, points);
                break;
            }

            case 2:
            {
                CreateEternalGoal(goalName, points);
                break;
            }

            case 3:
            {
                Console.WriteLine("How many times must the user complete this goal to receive the bonus?");
                int bonusThreshold = int.Parse(Console.ReadLine());
                break;
            }
            default:
            {
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
            }
        }

        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal would you like to record an event for?");
        string goalName = Console.ReadLine();
        Console.WriteLine("How many times did you complete the goal?");
        int count = int.Parse(Console.ReadLine());

        if (RecordEvent(goalName, count))
        {
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Failed to record event. Please try again.");
        }
    }
}