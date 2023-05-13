using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to the Journal Program");
        Menu menu = new Menu();
        
        int userInput = -1;
        Prompt randomPromptGenerator = new Prompt();
        Entry newEntry = new Entry();
        Journal myJournal = new Journal();
        while (userInput != 5)
        {   
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

            }
        

            if (userInput == 2)
            {
                myJournal.Display();
            }
            if (userInput == 3)
            {
                Console.Write("What is the filename");
                string fileName = Console.ReadLine();
                using (StreamWriter outPutFile = new StreamWriter(fileName, true))
                {
                    outPutFile.WriteLine(newEntry.newEntry());
                }
            }
            if (userInput == 4)
            {
                Console.Write("What is the filename");
                string fileName = Console.ReadLine();
                string [] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            if (userInput == 5)
            {
                Console.Write("Thank you for taking your time to fill your Journal");
            }
        }
    }
}