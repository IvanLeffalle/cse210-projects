using System;
using System.Globalization;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }
    static int PromptUserNumber()
    {
        int favoriteNumber = 0;
        Console.Write("Please enter your favorite number: ");
        string UserNumber = Console.ReadLine();
        favoriteNumber = int.Parse(UserNumber);
        return favoriteNumber;
    }
    static int SquareNumber(int favoriteNumber)
    {
        int square = favoriteNumber * favoriteNumber;
        return square;
    }
    static void DisplayResult(string UserName, int SquareNumber)
    {
        Console.WriteLine($"Brother {UserName}, the square of your number is {SquareNumber}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int number = SquareNumber(favoriteNumber);
        DisplayResult(userName, number);
    }
}