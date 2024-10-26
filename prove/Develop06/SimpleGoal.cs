public class SimpleGoal : Goal
{

    public SimpleGoal(string Name, string description, int points) : base(Name, description, points)
    {
    }
    

    public override string GetDetailsString()
    {
        return $"SimpleGoal,{_shortName}, {_description}, {_points}, {_isCompleted}";
    }
    public override bool isCompleted()
    {
        return _isCompleted;
    }

    public override void RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!\n");
        }
    }
    public override string GetStringRepresentation()
    {
        if (isCompleted())
        {
            return $"[X] {_shortName}: {_description} ";
        }
        else
        {
            return $"[ ] {_shortName}: {_description} ";
        }
    }

}
