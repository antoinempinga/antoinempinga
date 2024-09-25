using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("Welcome to my grader Game")
        Console.Write("What is your full name :")
        string name = Console.ReadLine();

        Console.Write($" Dear {name} What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"{name} Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine(${name} "You passed!");
        }
        else
        {
            Console.WriteLine($"Thanks dear {name} Good Job and wishing you all the best for next terme!");
        }
    }
}