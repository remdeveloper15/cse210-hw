using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._endYear = 2010;
        job1._startYear = 1999;

        job2._company = "Apple";
        job2._jobTitle = "Teacher";
        job2._endYear = 2002;
        job2._startYear = 2023;

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._name = "Allison Rose";
        
        resume1.DisplayResumeInfo();


    }
}