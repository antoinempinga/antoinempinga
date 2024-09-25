using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("Welcome to my ID Game")

        Console.Write("What is your full name :")
        string name = Console.ReadLine();
        Console.Write("Enter your Adress:")
        string Adress = Console.ReadLine();
        Console.Write("What is your Number :")
        int Number = Console.ReadLine();
        Console.WriteLine("Here your ID")
        Console.WriteLine($"Name:{name}")
        Console.WriteLine($"Adress:{Adress}")
        Console.WriteLine($"Cell:{Number}")
        Console.Write("Thanks for playing my game, see you soon and Good By")
    }
}