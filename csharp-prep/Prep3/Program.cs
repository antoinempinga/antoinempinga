using System;

class Program
{
    static void Main(string[] args)
    {
        //user information
        Console.WriteLine("Hello!");
        Console.WriteLine("Welcome to my magic number Game")
        Console.Write("What is your full name :")
        string name = Console.ReadLine();
         static void Main(string[] args)
         //main game
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            while (guess != magicNumber)
            {
                Console.Write($"Dear{name}What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber=guess)
                {
                    Console.WriteLine("The magic Number and guess are egal")
                }
                else if(magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"Congratulation dear{name}, You guessed it!");
                }
            }    
        }
    }
}