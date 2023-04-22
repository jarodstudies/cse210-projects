using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numberSeries = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a list of Numbers write down 0 when you finished: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numberSeries.Add(number);
            }  

        }

        int sum = 0;

         

        foreach ( int numbers in numberSeries)
        {
            Console.WriteLine(numbers);

            sum += numbers;
        }

        Console.WriteLine($"The toatl sum is : {sum}");

        float average = ((float)sum) / numberSeries.Count;
        Console.WriteLine($"The average number is: {average}");

        int max = 0;

        foreach (int numbers in numberSeries)
        {

            if ( numbers > max)
            {
                max = numbers;
            }

        }

        Console.WriteLine($"The max number is: {max}");


    }
}