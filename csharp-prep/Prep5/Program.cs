using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        WelcomeMessage();

        string User = UserName();
        int number = UserNumber();

        int root = RootNumber(number);

        DisplayMessage(root, User);

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the programm!");
        }

        static string UserName()
        {
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int UserNumber()
        {
            Console.WriteLine("What is your number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int RootNumber (int number)
        {
            int square = number * number;

            return square;
        }

        static void DisplayMessage(float number, string name)
        {
            Console.WriteLine($"Brother {name}, your square root number is {number}.");
        }


    }
}