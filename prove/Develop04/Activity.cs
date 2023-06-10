using System;
using System.Diagnostics;
public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
    private double lastFrame;
    

    public Activity( string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public string GetWelcomeDisplay()
    {
        return $"Welcome to {_activityName}\n{_activityDescription}";
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public void ActivityDuration()
    {
        Console.Write("How long, in seconds, would you like your session?:  ");
        string newTime = Console.ReadLine();
        _activityDuration  = int.Parse(newTime);   
    }
    public int GetActivityDuration()
    {

        return _activityDuration;
    }
    public void GetEndingMessage()
    {
        Console.WriteLine("Well done");
        SpinnerAnimation();
        Console.WriteLine($"You have complete another {_activityDuration} seconds of the {_activityName}");
        SpinnerAnimation();
    }
    public void SpinnerAnimation()
    {
        List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
    }
    public void TimerAnimation(int seconds)
    {
       for ( int i = seconds ; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
    public Stopwatch sw = new Stopwatch();
    public double deltaTime()
    {
        TimeSpan ts = this.sw.Elapsed;
        double firstFrame = ts.TotalSeconds;
        double dt = firstFrame - lastFrame;
        this.lastFrame = ts.TotalSeconds;
        return dt;
    }

}