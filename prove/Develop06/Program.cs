using System;

class Program
//I have added the option to add an due date so that 
//when you create the goal you will be prompted to enter a due date. 
//If the due date has passed then when listing your goals the 
//program will add to that goal the label “missed” and will 
//not allow you to record that event anymore.
//This option only applies to simple goals
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

    }
}