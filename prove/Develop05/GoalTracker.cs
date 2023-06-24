public class GoalTracker
{
    private List<Goal> goals;
    private int _score;
    private int _newPoints;
    public GoalTracker()
    {
        goals = new List<Goal>();
        _score = 0;
    }

    
    public int Score
    {
        get { return _score; }
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
        bool isComplete = false;
        

        switch(goalType)
        {
            case 1:
            {
                SimpleGoal goal = new SimpleGoal(goalName, goalDescription, points, isComplete);
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
                int count = 0;
                Console.Write("How many times must the user complete this goal to receive the bonus?");
                int bonusThreshold = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                ChecklistGoal goal = new ChecklistGoal(goalName, goalDescription, points, bonusPoints, bonusThreshold, count);
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
            outPutFile.WriteLine(_score);
            foreach ( Goal goal in goals)
            {
                if (goal is SimpleGoal)
                {
                    outPutFile.WriteLine($"{goal}:{goal.Name()},{goal.Description()},{goal.Points()},{goal.IsComplete()}");   
                }
                if (goal is EternalGoal)
                {
                    outPutFile.WriteLine($"{goal}:{goal.Name()},{goal.Description()},{goal.Points()}");   
                }
                else if(goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    outPutFile.WriteLine($"{goal}:{goal.Name()},{goal.Description()},{goal.Points()},{checklistGoal.BonusPoints()}, {checklistGoal.BonusThreshold()},{checklistGoal.Count()}");
                }
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
            _score = int.Parse(newScore);
            return _score;
        }
        // call method to load score
        Loadscore();

        string [] lines= File.ReadAllLines(fileName);
        foreach (string line in lines.Skip(1))
        
        {
            var newline = line.Split(":");
            var objectType = newline[0];
            var objectDetails = newline[1];
            var part = objectDetails.Split(",");
            if (objectType == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(part[0], part[1], int.Parse(part[2]), bool.Parse(part[3]));
                goals.Add(simpleGoal);   
            }
            if (objectType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(part[0], part[1], int.Parse(part[2]));
                goals.Add(eternalGoal);
            }
            if (objectType == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(part[0], part[1],int.Parse(part[2]), int.Parse(part[3]), int.Parse(part[4]), int.Parse(part[5]));
                goals.Add(checklistGoal);
            }
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
                        _score += simpleGoal.RecordEvent(count);
                        _newPoints = goal.Points();
                        return true;
                    }
                    else if (goal is EternalGoal)
                    {
                        EternalGoal eternalGoal = (EternalGoal)goal;
                        _score += eternalGoal.RecordEvent(count);
                        _newPoints = goal.Points();
                        return true;
                    }
                    else if (goal is ChecklistGoal)
                    {
                        ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                        _score += checklistGoal.RecordEvent(count);
                        _newPoints = goal.Points();
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
            
            Console.WriteLine($"Congratulations! You have earned {_newPoints} points!.\nYou now have {_score} points\n");
        }
        else
        {
            Console.WriteLine("Failed to record event. Please try again.");
        }
        
    }
}