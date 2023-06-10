using System;
public class ListingActivity : Activity
{
    private  string [] listingPrompts = {
        "---Who are people that you appreciate?---",
        "---What are personal strengths of yours?---",
        "---Who are people that you have helped this week?---",
        "---When have you felt the Holy Ghost this month?---",
        "---Who are some of your personal heroes?---"
    };
    
    public ListingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
        
    }
    private string randomPrompt()
    {
        Random random = new Random();
        int number = random.Next(listingPrompts.Length);
        Console.WriteLine(listingPrompts[number]);
        return listingPrompts[number];
    }
    

    public void Display()
    {
        Console.WriteLine(GetWelcomeDisplay());
        ActivityDuration();

        Console.WriteLine("Get Ready...");
        SpinnerAnimation();
        
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        randomPrompt();
        Console.Write("You may begin in: ");
        TimerAnimation(3);
        Console.WriteLine();
        
        this.sw.Start();
        double acc = 0.0;
        List<string> buf = new List<string>();
        List<string> userResponses = new List<string>();
        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(GetActivityDuration());
        while (acc <= GetActivityDuration())
        {
            acc += this.deltaTime();
            if (!Console.KeyAvailable)
            {
                // Console.Write(">");
                continue;
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
                buf.Add("\n>");
                string userResponse= string.Join<string>("", buf);
                userResponses.Add(userResponse);
            }
            else
            {
                buf.Add(key.KeyChar.ToString());
            }
        };
        int occurences = userResponses.Count();
        Console.WriteLine($"You have listed {occurences} items");
        GetEndingMessage();
    }

}