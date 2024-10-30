public class Activity
{
    protected string _type;
    protected int _length;
    protected double _distance;
    protected int _speed;
    protected int _pace;
    protected DateTime _today;

    public Activity(string type, double distance, int length, DateTime today)
    {
        _type = type;
        _distance = distance;
        _length = length;
        _today = today;
    }
    public virtual double GetDistance()
    {
        return _distance;
    }
    public virtual int GetSpeed()
    {
        if (_length == 0) return 0;
        _speed = (int)((_distance * 60) / _length);
        return _speed;
    }
    public virtual int GetPace()
    {
        if (_distance == 0) return 0;
        _pace = (int)(_length / _distance);
        return _pace;
    }

    public virtual string GetSummary()
    {
        GetPace();
        GetSpeed();
        GetDistance();
        return $"{_today.ToString("MM/dd/yyyy")} {_type} ({_length} min) - Distance: {_distance} km, Speed: {_speed} km/h, Pace: {_pace} min/km";
    }

}
