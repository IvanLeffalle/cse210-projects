public class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
"Who was the most interesting person I interacted with today?",
"What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be?",
"What is one lesson I learned today, and how can I apply it moving forward?",
"What challenge did I face today, and how did I overcome it?",
"What am I grateful for that happened today, big or small?",
"Who inspired me today, and what about them sparked that inspiration?",
"What was a moment of joy or laughter I experienced today?",
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}