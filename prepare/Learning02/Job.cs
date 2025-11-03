using System;

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