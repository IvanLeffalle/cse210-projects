public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
    }
    public void RunBreathingActivity()
    {
        DisplayStartMessage();
        ShowSpinner(2);
        int allTime = _duration;
        int cycle = 4;
        while (allTime > 0)
        {
            Console.Write("Breathe in...");
            ShowCountdown(Math.Min(allTime, cycle));
            allTime -= cycle;

            if (allTime <= 0) break;

            Console.Write("Now breathe out...");
            ShowCountdown(Math.Min(allTime, cycle));
            allTime -= cycle;
            Console.WriteLine();
        }
        DisplayEndMessage();
        ShowSpinner(2);
    }
}
