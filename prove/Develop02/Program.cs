using System;
//To exceed the requirements I have added the author option when creating the entry
class Program
{
    static void Main(string[] args)
    {

        Journal myJournal = new Journal();
        string fileName = null;

        int responseOption = 0;
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");

        while (responseOption != 5)
        {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do? ");
            string response = Console.ReadLine();
            responseOption = int.Parse(response);
            if (responseOption == 1)
            {
                myJournal.AddEntry();
            }
            else if (responseOption == 2)
            {
                myJournal.DisplayAll();
            }
            else if (responseOption == 3)
            {
                Console.WriteLine("What is the filename?  ");
                fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);

            }
            else if (responseOption == 4)
            {
                Console.WriteLine("What is the filename?  ");
                fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }

        }
    }
}