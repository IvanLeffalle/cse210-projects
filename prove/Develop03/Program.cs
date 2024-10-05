//For "Showing Creativity and Exceeding Requirements"
//I added the option for the user to select which book the scripture should be taken from.
//So far I only added two books (Old and New Testament).
//To do this, I added two new classes (Old and New Testament).
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Select a Testament: Type 'old' for Old Testament or 'new' for New Testament: ");
        string userChoice = Console.ReadLine().ToLower();
        Scripture selectedScripture = null;

        if (userChoice == "old")
        {
            OldTestament oldTestament = new OldTestament();
            selectedScripture = oldTestament.GetRandomScripture();
        }
        else if (userChoice == "new")
        {
            NewTestament newTestament = new NewTestament();
            selectedScripture = newTestament.GetRandomScripture();

        }
        else
        {
            Console.WriteLine("Invalid selection.");
            return;
        }
        Console.WriteLine(selectedScripture.GetDisplayText());
        while (true)
        {
            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congrats!");
                break;
            }
            Console.WriteLine("Please press ENTER to hide words or type 'quit' to exit.");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            selectedScripture.HideRandomWords(3);
            Console.WriteLine(selectedScripture.GetDisplayText());

        }
    }
}