abstract class Activity
{
    private string _date;
    private int _length;
    private string _name;

    public Activity(string date, int length, string name)
    {
        _date = date;
        _length = length;
        _name = name;
    }

    public int GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_name} ({_length} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }

}