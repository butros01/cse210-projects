using System;
using System.Diagnostics;
public class BreathingActivity : Activity
{
    private string _breathIn;
    private string _breathOut;

    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    { 

    }

    private void GetBreathIn()
    {
        _breathIn = "Breath In....... ";
        Console.Write(_breathIn);
        TimerAnimation(6);
       
    }
    private void GetBreathOut()
    {
        _breathOut = "Now Breath Out... ";
        Console.Write(_breathOut);
        TimerAnimation(5); 
    }

    public void Display()
    {
        // sw.Reset();
        // sw.Start();
        // double acc = 0.0;
        Console.WriteLine(GetWelcomeDisplay());
        Console.WriteLine("");
        ActivityDuration();
        Console.WriteLine("");
        Console.WriteLine("Get Ready...");
        SpinnerAnimation();
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetActivityDuration());
        while (DateTime.Now < futureTime)
        {
            // acc += deltaTime();
            GetBreathIn(); 
            Console.WriteLine();
            GetBreathOut();
            Console.WriteLine("\n");    
        };
        GetEndingMessage();
    }
}