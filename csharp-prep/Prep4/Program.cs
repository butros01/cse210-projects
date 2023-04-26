using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number:");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        // Compute the sum
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");

        // compute the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the max
        int max = numbers[0];
        foreach(int i in numbers)
        {
            if(i>max)
            {
            max = i;
            }
        }

        Console.WriteLine($"The max is {max}");

    }
}