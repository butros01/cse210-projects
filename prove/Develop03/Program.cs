using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // set console color
        Console.BackgroundColor = ConsoleColor.DarkRed;
        // clear the console
        Console.Clear();
        // declear numbers Hidden count
        int numbersHiddenTotal = 0;
        // import random
        Random random = new Random();
        int hiddenWord = random.Next(3);
        // instatiate reference for classes
        Word newWord = new Word();
        Reference newReference = new Reference("John",3,16);
        Scripture newScripture = new Scripture( Scripture.GetReference(), "For God so loved the world that, he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        // Clear the console screen
        Console.Clear();

        // Display the complete scripture
        Console.WriteLine($"{Scripture.GetReference()} {Scripture.GetText()}");

        // Prompt the user to press enter or type quit
        Console.WriteLine("Press enter to hide a few random words or type 'quit' to end the program.");
        //Create a list to store the hidden words
        List <int> hiddenWords = newScripture.GetHiddenWords();
        // create a variable to the list of words 
        List <string> words = newScripture.GetWordsList();
        // Ilatrate through the list of words the assing the word the Word resposibilities
        foreach (string word in words)
        {
            // newWord.GetWord() = word;
            newScripture.GetWords().Add(word);
        }
        // Loop until all words are hidden or the user types quit
        while (numbersHiddenTotal != words.Count())
        {
            // Read the user input
            string input = Console.ReadLine();

            // Check if the user typed quit
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a  random word
            
            
            hiddenWord = random.Next(0, newScripture.GetWords().Count);
            while (!hiddenWords.Contains(hiddenWord))
            {
                
                hiddenWords.Add(hiddenWord);
                
                
                if (newWord.GetHidden() == false)
                {
                    newScripture.GetWords()[hiddenWord] = new string('_', newScripture.GetWords()[hiddenWord].Count());
                }
                // Scripture._words[hiddenWord] = new string('_', newScripture.Getwords()[hiddenWord].Count());
                numbersHiddenTotal += 1;
            
                
               
            }
            

            // Clear the console screen
            Console.Clear();

            // Display the rendered text
            newScripture.Display();
            
            // Prompt the user to press enter or type quit
            Console.WriteLine("Press enter to hide a few more random words or type 'quit' to end the program.");
        }
    }  
}