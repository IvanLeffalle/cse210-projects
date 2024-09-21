using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);

        string letter = null;


        if (numberGrade >= 90)
        {
            letter = "A";

        }
        else if (numberGrade >= 80)
        {
            letter = "B";

        }
        else if (numberGrade >= 70)
        {
            letter = "C";

        }
        else if (numberGrade >= 60)
        {
            letter = "D";

        }
        else if (numberGrade < 60)
        {
            letter = "F";

        }
        Console.WriteLine($"Your grade is {letter}.");


        if (numberGrade > 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else if (numberGrade < 70)
        {
            Console.WriteLine("Sorry, you didn't pass the course. Please try again next year.");
        }
    }
}