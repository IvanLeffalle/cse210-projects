using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Ivan Leffalle", "C#");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Ivan Leffalle", "Math", "1.1", " 7-9");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Ivan Leffalle", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}