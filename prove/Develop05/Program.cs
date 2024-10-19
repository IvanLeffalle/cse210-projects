using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: \n1. Start breathing activity \n2. Start reflection activity \n3. Start listing activity \n4. Quit");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunBreathingActivity();
                Console.WriteLine("");
            }
            else if (userChoice == "2")
            {
                ReflectionActivity reflectingActivity = new ReflectionActivity();
                reflectingActivity.RunReflectionActivity();
                Console.WriteLine("");
            }
            else if (userChoice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunListingActivity();
                Console.WriteLine("");
            }
            else if (userChoice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");

            }

        }

    }
}