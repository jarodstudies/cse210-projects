using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");



        //Console.Write("Choose a magic number: ");
        //string number = Console.ReadLine();
        //int magicNumber = int.Parse(number);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1 ;

        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed correctly!!");
            }
            

        } 

    }
}