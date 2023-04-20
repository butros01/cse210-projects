using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name?");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name?");
        string second_name= Console.ReadLine();
        Console.WriteLine($"Your name is {second_name}, {first_name} {second_name}");
    }
}