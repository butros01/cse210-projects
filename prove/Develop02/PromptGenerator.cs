using System;
public class Prompt
{
    public string _randomPromptGenerator;
    
    string [] prompts = {
        "Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?",
        "How did I progress towards achieving my set goal for this year"
    };

    public string randomPrompt()
    {
        Random random = new Random();
        int number = random.Next(prompts.Length);
        Console.WriteLine(prompts[number]);
        return prompts[number];
    }
}