public class SimpleGoal : Goal
{

    private DateTime _targetDate;
    private DateTime _today;
    public SimpleGoal(string Name, string description, int points, DateTime targetDate) : base(Name, description, points)
    {

        _targetDate = targetDate;
        _today = DateTime.Now.Date;
    }

    public string isMissed()
    {
        if (_today > _targetDate)
        {
            return "missed";
        }
        return "not missed";
    }
    public override string GetDetailsString()
    {
        return $"SimpleGoal,{_shortName}, {_description}, {_points}, {_isCompleted}, {_targetDate}";
    }
    public override bool isCompleted()
    {
        return _isCompleted;
    }

    public override void RecordEvent()
    {
        if (isMissed() == "missed")
        {
            Console.WriteLine("You have missed this goal, so it cannot be completed.\n");
        }
        if (!_isCompleted)
        {
            _isCompleted = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!\n");
        }
    }
    public override string GetStringRepresentation()
    {
        if (isMissed() == "missed")
        {
            return $"[ ] {_shortName}: {_description} (missed) ";
        }
        if (isCompleted())
        {
            return $"[X] {_shortName}: {_description} ";
        }
        else
        {
            return $"[ ] {_shortName}: {_description}, due {_targetDate} ";
        }
    }
}
