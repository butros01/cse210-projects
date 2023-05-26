using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Reference newReference = new Reference("John", 3,16);
        Scripture newScripture = new Scripture( Scripture.GetReference(), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        
        Word word = new  Word();
        // Clear the console screen
        Console.Clear();

        // Display the complete scripture
        Console.WriteLine($"{Scripture.GetReference()} {Scripture.GetText()}");

        // Prompt the user to press enter or type quit
        Console.WriteLine("Press enter to hide a few random words or type 'quit' to end the program.");

        // Loop until all words are hidden or the user types quit
        while (word.GetHidden().Count < word.GetWords().Length)
        {
            // Read the user input
            string input = Console.ReadLine();

            // Check if the user typed quit
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a few random word
            word.hideWord();

            // Clear the console screen
            Console.Clear();

            // Display the scripture with hidden words
            word.Display();
            
            // Prompt the user to press enter or type quit
            Console.WriteLine("Press enter to hide a few more random words or type 'quit' to end the program.");
        }
    }
}