using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Jane Doe", "History");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Section 5.2", "Problems 1-10", "John Smith", "Algebra");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("The Renaissance", "2024-05-01", "Emily Johnson", "Art History");
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}