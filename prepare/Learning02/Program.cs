using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._title = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2025;
        //job1.Display();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._title = "Netowrk Engineer";
        job2._startYear = 2010;
        job2._endYear = 2019;
        //job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Tyler";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}