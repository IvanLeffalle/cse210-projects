public class ReflectionActivity : Activity
{
    protected List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Recall a moment when you achieved a difficult goal.",
        "Reflect on a time when you helped someone in need.",
        "Remember a situation where you overcame a significant challenge.",
        "Think of a time when you demonstrated resilience in the face of adversity."
    };
    protected List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "Have you ever done anything like this in your life?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?"
    };

    public ReflectionActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {


    }

    public void RunReflectionActivity()
    {
        DisplayStartMessage();
        ShowSpinner(2);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        var random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[index]}");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine();

        ShowSpinner(4);
        Console.WriteLine("You may begin in: ");

        ShowCountdown(3);

        Console.Clear();


        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int questionIndex = random.Next(_questions.Count);
            Console.WriteLine($"---{_questions[questionIndex]}");
            Console.WriteLine();
            ShowSpinner(2);
            Console.WriteLine("Press enter when you have completed that.");
            Console.ReadLine();
        }
        {
            DisplayEndMessage();
            ShowSpinner(2);
        }
    }

}

