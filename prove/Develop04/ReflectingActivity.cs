using System;
public class ReflectingActivity : Activity
{
    private string [] reflectingRandomPrompts = {
        "****Think of a time when you stood up for someone else.****",
        "****Think of a time when you did something really difficult.****",
        "****Think of a time when you helped someone in need.****",
        "****Think of a time when you did something truly selfless.****"
    };
    private string [] reflectingQuestionPrompts = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    { 
    }

    public string Questions()
    {
        Random random = new Random();
        int number = random.Next(reflectingQuestionPrompts.Length);
        Console.Write($"> {reflectingQuestionPrompts[number]}");
        return reflectingQuestionPrompts[number];
    }
    public string randomReflectingPrompt()
    {
        Random random = new Random();
        int number = random.Next(reflectingRandomPrompts.Length);
        Console.WriteLine(reflectingRandomPrompts[number]);
        return reflectingRandomPrompts[number];
    }

    public void Display()
    {
        Console.WriteLine(GetWelcomeDisplay());
        ActivityDuration();
        
        Console.WriteLine("Get Ready...");
        SpinnerAnimation();
        Console.WriteLine("\n");
        Console.WriteLine("Consider the following prompt: ");
        randomReflectingPrompt();
        Console.WriteLine("When you have something in Mind press enter to continue.");
        string newUserEntry = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        TimerAnimation(4);
        Console.WriteLine();
        this.sw.Start();
        double acc = 0.0;
        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(GetActivityDuration());
        while (acc <= GetActivityDuration())
        {
            acc += this.deltaTime();
            Questions();
            SpinnerAnimation();
            Console.WriteLine();      
        };
        GetEndingMessage();
    }
}