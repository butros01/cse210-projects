using System;

class Program
{
    static void Main(string[] args)
    {
        // set console color
        Console.BackgroundColor = ConsoleColor.DarkRed;
        //Display welcome message
        Console.WriteLine("Hello, Welcome to the Mindfulness Program");
        //Store menu options into a variable
        string menu = "Menu options\n 1. Start BreathingActivity\n 2. Start Reflecting Activity\n 3. Start Listing Activity\n 4. Quit";
        //Declare new instances for Activity class, ListingActivity class, BreathingActivity class and ReflectingActivity class
        Activity activity = new Activity(string.Empty, string.Empty);
        ListingActivity listingActivity = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        // Declare the value of userInput before using it
        int userInput = -1;
        // Loop through the program to run until the user presses 4 as quit option
        while (userInput != 4)
        {   
            //Display the menu options
            Console.WriteLine(menu);
            Console.Write("Select a choice from the menu: ");
            // Take userInput
            string newUserInput = Console.ReadLine();
            userInput = int.Parse(newUserInput);
            Console.Clear();
            // Check the userInput
            if (userInput == 1)
            {
                breathingActivity.Display();
            }
            Console.Clear();
            // Check the userInput
            if (userInput == 2)
            {
                reflectingActivity.Display();
            }
            Console.Clear();
            // Check the userInput
            if (userInput == 3)
            {
                listingActivity.Display();
            }
            if (userInput == 4)
            {
                Console.WriteLine("Thank you for participating in the Mindfulness Activity");
            }       
        }
    }
}