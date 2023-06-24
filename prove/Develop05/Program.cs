using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the GoalTracker class
        GoalTracker tracker = new GoalTracker();
        int response = 0;
        while (response != 6)
        {
            // Console.Clear();
            Console.WriteLine($"You have {tracker.Score} points\n");
            Console.WriteLine($"Menu Options\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select Choice from the Menu: ");
            response = int.Parse(Console.ReadLine());
            Console.WriteLine();
            // Allow the user to create new goal
            if (response == 1)
            {
                tracker.CreatNewGoal();
            }
            // Show the list of goals to the user
            if (response == 2)
            {
                tracker.ListGoals();
            }
            // Save the user's goals and score to file
            if (response == 3)
            {
               
                tracker.Save();
            }
            // Allow the user to load goals from a file
            if (response == 4)
            {
                tracker.Load();
            }
            // Allow the user to record an event
            if (response == 5)
            {
                tracker.RecordEvent();
            }

            // Allow user to enter option to quit
            if (response == 6)
            {
                Console.WriteLine("Program Terminated.\nTHANK YOU FOR PARTICIPATING !!!");
            }
        }
    }
}