public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, int length) : base("Swimming", 0, length, DateTime.Now)
    {
        _laps = laps;
        _distance = GetDistanceFromLaps();
    }

    private double GetDistanceFromLaps()
    {
        return (_laps * 50) / 1000.0;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override string GetSummary()
    {
        GetPace();
        GetSpeed();
        return $"{_today.ToString("MM/dd/yyyy")} {_type} ({_length} min) - Distance: {_distance} km, Speed: {_speed} km/h, Pace: {_pace} min/km - Laps: {_laps}";
    }
}
