using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int userInputNumber = 999999999;
        int sum = 0;
        float average = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> numbers = new List<int>();
        while (userInputNumber != 0)
        {
            Console.WriteLine("Enter number: ");
            string userImput = Console.ReadLine();
            userInputNumber = int.Parse(userImput);
            numbers.Add(userInputNumber);

        }
        if (numbers.Count > 0)
        {
            foreach (int number in numbers)
            {
                sum += number;
                if (number > largest)
                {
                    largest = number;
                }
            }
        }
        average = (float)sum / numbers.Count;



        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}