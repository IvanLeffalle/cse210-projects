public class ChecklistGoal : Goal
{

    public int _ammountCompleted = 0;
    public int _target;
    public int _bonus;
    public ChecklistGoal(string Name, string description, int points, int target, int bonus) : base(Name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _ammountCompleted = 0;

    }
    public override bool isCompleted()
    {
        return _ammountCompleted >= _target;
    }
    public override void RecordEvent()
    {
        if (_ammountCompleted < _target)
        {
            _ammountCompleted++;

            Console.WriteLine($"Congratulations! You have earned {_points} points!");

            if (_ammountCompleted >= _target)
            {
                _isCompleted = true;
                Console.WriteLine($"Congratulations! You have earned {_bonus} bonus points!");
                _points += _bonus;
            }
        }
        else
        {
            Console.WriteLine("Goal is already completed.");
        }
    }

    public void SetCurrentCount(int count)
    {
        _ammountCompleted = count;
    }

    public override string GetDetailsString()
    {
        return $"ChecklistGoal,{_shortName}, {_description}, {_points}, {_isCompleted}, {_ammountCompleted}, {_target}, {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        if (isCompleted())
        {
            return $"[X] {_shortName}: {_description} (Currentlly Completed: {_ammountCompleted} / {_target})";
        }
        else
        {
            return $"[ ] {_shortName}: {_description} (Currentlly Completed: {_ammountCompleted} / {_target})";
        }
    }
}