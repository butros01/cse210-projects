using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // set console color
        Console.BackgroundColor = ConsoleColor.DarkRed;
        //Display welcome message
        List <string> list = new List<string>();
        Console.WriteLine("Hello, Welcome to the Journal Program");
        Menu menu = new Menu();

        int userInput = -1;
        Prompt randomPromptGenerator = new Prompt();
        Journal myJournal = new Journal();

        while (userInput != 5)
        {   
            Entry newEntry = new Entry();
            menu.Display();
            Console.Write("What would you like to do? ");
            string newUserInput = Console.ReadLine();
            userInput = int.Parse(newUserInput);
            if (userInput == 1)
            {

                string prompt = randomPromptGenerator.randomPrompt();
                Console.Write(">");
                string reply = Console.ReadLine();
                newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                newEntry._prompt = prompt;
                newEntry._reply = reply;
                myJournal._entries.Add(newEntry);
                list.Clear();
                foreach ( Entry line in myJournal._entries)
                {
                    list.Add(line.completeEntry());
                }
            }
        

            if (userInput == 2)
            {
                
                foreach ( string line in list)
                    {
                        Console.WriteLine(line);
                    }
                
            }
            if (userInput == 3)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                using (StreamWriter outPutFile = new StreamWriter(fileName, true))
                {
                    foreach ( string line in list)
                    {
                        outPutFile.WriteLine(line);
                    }
                }     
            }
            if (userInput == 4)
            {
                list.Clear();
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                string [] lines= File.ReadAllLines(fileName);

                foreach (string line in lines)

                {
                    list.Add(line);
                }
                    
            }
            if (userInput == 5)
            {
                Console.Write("Thank you for taking your time to fill your Journal");
            }
        }
    }
}