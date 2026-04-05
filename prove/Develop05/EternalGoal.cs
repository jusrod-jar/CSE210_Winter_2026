class EternalGoal : Goal
{
    public EternalGoal() : base("Eternal")
    {

    }
    public override void CreateGoal()
    {
        base.SetBaseProperties();
    }


    public override string ListGoal()
    {

        return $"[{DisplayStatus()}] {_name} ({_description}) - {_goalType}";
    }
    public override int RecordEvent()
    {
        return _goalPoints;
    }
    public override string SaveGoal()
    {
        return $"{_goalType}~{_name}~{_description}~{_goalPoints}";
    }
    public override void LoadGoal(string[] parts)
    {
        _name = parts[1];
        _description = parts[2];
        _goalPoints = int.Parse(parts[3]);
    }
}