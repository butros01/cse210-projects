using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);
        int userGuess = -1;
        while (userGuess != magicNumber)
        {   
            Console.Write("What is the magic magicNumber");
            userGuess = int.Parse(Console.ReadLine());
            
            if (magicNumber > userGuess)
            {
            Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        }


    }
}