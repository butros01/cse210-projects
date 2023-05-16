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
            }
        

            if (userInput == 2)
            {
                myJournal.Display();
            }
            if (userInput == 3)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                using (StreamWriter outPutFile = new StreamWriter(fileName, true))
                {
                    foreach ( Entry line in myJournal._entries)
                    outPutFile.WriteLine(line.completeEntry());
                }     
            }
            if (userInput == 4)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                string [] lines= File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    
                    myJournal._entries.Add(line);
                }
            }
            if (userInput == 5)
            {
                Console.Write("Thank you for taking your time to fill your Journal");
            }
        }
    }
}