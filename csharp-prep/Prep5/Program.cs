using System;

class Program
{
    static void Main(string[] args)
    {
        //user information
        Console.WriteLine("Hello!");
        Console.WriteLine("Welcome to my List Game")
        Console.Write("What is your full name :")
        string fullname = Console.ReadLine();
        //Main program
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
     static void DisplayResult(string fullname)
     {
        Console.Write($"Thanks {fullname} for playing my game, see you soon and Good Bye!")
     }
}