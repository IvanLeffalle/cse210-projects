public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;
    protected Goal(string Name, string description, int points)
    {

        _shortName = Name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }
    public abstract void RecordEvent();
    public virtual bool isCompleted()
    {
        return _isCompleted;
    }
    public virtual string GetDetailsString()
    {
        return $"{_shortName}, {_description}, {_points}, {_isCompleted}";
    }
    public virtual string GetStringRepresentation()
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
