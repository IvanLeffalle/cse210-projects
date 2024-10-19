public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "How did I connect with my family today?",
        "What was the strongest emotion I felt today?",
        "What was one challenge I faced today?",
        "What am I grateful for that happened today, big or small?",
        "Who inspired me today, and what about them sparked that inspiration?",
    };
    private int _count;


    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"---{prompt}---");
        return prompt;
    }

    public List<string> GetListFromUser(string prompt)
    {
        Console.WriteLine(prompt);
        List<string> responses = new List<string>();
        _count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            _count++;
        }
        Console.WriteLine($"You listed {_count} items.");
        return responses;
    }

    public void RunListingActivity()
    {
        DisplayStartMessage();
        ShowSpinner(2);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("You may begin in:");

        ShowCountdown(3);

        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            GetListFromUser(prompt);
        }
        DisplayEndMessage();
        ShowSpinner(2);
    }

}