public class BreathingActivity : Activity
{
    private string _breathIn;
    private string _breathOut;

    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    { 

    }

    public void GetBreathIn()
    {
        _breathIn = "Breath In....... ";
        Console.Write(_breathIn);
        TimerAnimation(6);
       
    }
    public void GetBreathOut()
    {
        _breathOut = "Now Breath Out... ";
        Console.Write(_breathOut);
        TimerAnimation(5); 
    }

    public void Display()
    {
        Console.WriteLine(GetWelcomeDisplay());
        ActivityDuration();
        Console.WriteLine("\n");
        Console.WriteLine("Get Ready...");
        SpinnerAnimation();
        Console.WriteLine("\n");

        this.sw.Start();
        double acc = 0.0;
        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(GetActivityDuration());
        while (acc <= GetActivityDuration())
        {
            acc += this.deltaTime();
            GetBreathIn(); 
            Console.WriteLine();
            GetBreathOut();
            Console.WriteLine("\n");      
        };
        GetEndingMessage();
    }
}