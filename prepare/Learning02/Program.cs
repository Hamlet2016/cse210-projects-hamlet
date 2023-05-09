using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._salary = 1200.00;
        job1._startYear = new DateTime(2021, 1, 1);
        job1._endYear = 2023;
        //Console.WriteLine(job1._company);
        

        Job job2 = new Job();
        job2._jobTitle = "Project Manager";
        job2._company = "Apple";
        job2._salary = 4000.00;
        job2._startYear = 2011;
        job2._endYear = 2022;
        //Console.WriteLine(job2._company);
        //job2.DisplayJobDetails();
    }

    Resume myResume = new Resume("Allison Rose");
    myResume.Jobs.Add(job1);
    myResume.Jobs.Add(job2);

    Console.WriteLine(myResume.Jobs[0]._jobTitle);

    myResume.Display();
}