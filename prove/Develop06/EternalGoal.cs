public class EternalGoal : Goal
{

    public EternalGoal(string Name, string description, int points) : base(Name, description, points)
    {

    }
    public override string GetDetailsString()
    {
        return $"EternalGoal,{_shortName}, {_description}, {_points}, {_isCompleted}";
    }
    public override bool isCompleted()
    {
        return false;
    }
    public override void RecordEvent()
    {

        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
}
