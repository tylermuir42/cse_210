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

        job1.Display();

        Resume resume1 = new Resume();
        resume1._name = "Tyler";
        resume1._jobs.Add(job1);

        resume1.Display();
    }
    public class Job
    {
        public string _company;
        public string _title;
        public int _startYear;
        public int _endYear;

        public string Display()
        {
            string info = $"{_title} ({_company}) {_startYear}-{_endYear}";
            Console.WriteLine(info);
            return info;
        }
    }

    public class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();

        public string Display()
        {
            string info = $"Name: {_name}\n Jobs: {_jobs}";
            Console.WriteLine(info);
            return info;
        }
    }
}