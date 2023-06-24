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

    public void CreateSimpleGoal(string name, string description, int points)
    {
        SimpleGoal goal = new SimpleGoal(name, description, points);
        goals.Add(goal);
    }

    public void CreateEternalGoal(string name, string description, int points)
    {
        EternalGoal goal = new EternalGoal(name, description, points);
        goals.Add(goal);
    }

    public void CreateChecklistGoal(string name, string description, int bonusThreshold, int bonusPoints, int points)
    {
        ChecklistGoal goal = new ChecklistGoal(name, description, bonusThreshold, bonusPoints, points);
        goals.Add(goal);
    }

    

    
    public void GetList()
    {
        foreach (Goal goal in goals)
        {
            Console.Write($"[{(goal.IsComplete() ? "X" : " ")}] {goal.Name()} ({goal.Description()})");

            if (goal is ChecklistGoal)
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                Console.WriteLine($" --Currently completed: {checklistGoal.Count()}/{checklistGoal.BonusThreshold()} times");
            }
        }

    }
    public void Save()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        File.WriteAllText(fileName, String.Empty);
        using (StreamWriter outPutFile = new StreamWriter(fileName, true))
        {
            outPutFile.WriteLine(score);
            foreach ( Goal goal in goals)
            {
                outPutFile.WriteLine($"{goal}:{goal.Name()},{goal.Description()},{goal.Points()},[{(goal.IsComplete() ? "X" : " ")}]");
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
            var newline = line.Split(":");
            var objectDetails = newline[1];
            var part = objectDetails.Split(",");
            // incomplete code
        }
    }

    public void CreatNewGoal()
    {
        Console.WriteLine($"The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist goal");
        Console.Write("Which type of goal would you like to create? (1/2/3): ");
        int goalType = int.Parse(Console.ReadLine());
        Console.Write("What is the name of the goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch(goalType)
        {
            case 1:
            {
                SimpleGoal goal = new SimpleGoal(goalName, goalDescription, points);
                goals.Add(goal);
                break;
            }

            case 2:
            {
                EternalGoal goal = new EternalGoal(goalName, goalDescription, points);
                goals.Add(goal);
                break;
            }

            case 3:
            {
                
                
                Console.Write("How many times must the user complete this goal to receive the bonus?");
                int bonusThreshold = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                ChecklistGoal goal = new ChecklistGoal(goalName, goalDescription, bonusThreshold, bonusPoints, points);
                goals.Add(goal);
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

    public void ListGoals()
    {
        foreach (Goal goal in goals)
        {
            if (goal is SimpleGoal or EternalGoal)
            Console.WriteLine($"[{(goal.IsComplete() ? "X" : " ")}] {goal.Name()} ({goal.Description()})");

            else if(goal is ChecklistGoal)
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                Console.WriteLine($"[{(goal.IsComplete() ? "X" : " ")}] {goal.Name()} ({goal.Description()}) ---Currently completed: {checklistGoal.Count()}/{checklistGoal.BonusThreshold()} times");
            }
        }

    }
    public void Save()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        File.WriteAllText(fileName, String.Empty);
        using (StreamWriter outPutFile = new StreamWriter(fileName, true))
        {
            outPutFile.WriteLine(score);
            foreach ( Goal goal in goals)
            {
                outPutFile.WriteLine($"{goal}:{goal.Name()},{goal.Description()},{goal.Points()},{goal.IsComplete()}");
                
            }

        }
    }

    public void Load()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        int Loadscore()
        {
            string newScore = File.ReadLines(fileName).Take(1).First();
            score = int.Parse(newScore);
            return score;
        }
        // call method to load score
        Loadscore();

        string [] lines= File.ReadAllLines(fileName);
        List<string> list = new List<string>();
        foreach (string line in lines.Skip(1))
        
        {
            var newline = line.Split(":");
            var objectDetails = newline[1];
            var part = objectDetails.Split(",");
            list.Add($"{part[3]} {part[1]} {part[2]}");
            // I need help with completing this code. 
            // I want this to be added in the goals list 
            // I do not not hoe to do that. I have 
            // researched but no help.
        }       
    }

    
    public void RecordEvent()
    
    {
        bool RecordEvent(string name, int count)
        {
            foreach (Goal goal in goals)
            {
                if (goal.Name().ToLower() == name.ToLower())
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

        Console.WriteLine("The Goals are: ");
        
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goal.Name()}");
        }
        Console.Write("Which goal would you like to accomplish? ");
        string goalName = Console.ReadLine();
        
        if (RecordEvent(goalName, 1))
        {
            Console.WriteLine($"Congratulations! You have earned {score} points!.\nYou now have {score} points");
        }
        else
        {
            Console.WriteLine("Failed to record event. Please try again.");
        }
        
    }
}