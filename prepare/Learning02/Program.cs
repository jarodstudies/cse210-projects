using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();

        job1._company = "DocIT";
        job1._jobTitle = "Support";
        job1._startYear = 2019;
        job1._endYear = 2021;

        job1.DisplayJobDetails();
        
        
        Job job2 = new Job();
        job2._company = "Samsung";
        job2._jobTitle = "Technician";
        job2._startYear = 2015;
        job2._endYear = 2018;

        job2.DisplayJobDetails();

        Resume myresume1 = new Resume();
        myresume1._name = "Jarod Ramos";

        myresume1._jobs.Add(job1);
        myresume1._jobs.Add(job2);

        myresume1.DisplayResume();


    }
}