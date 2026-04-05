class SimpleGoal : Goal
{
    public SimpleGoal(): base("Simple")
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
        _status = true;
        return _goalPoints;
    }

    public override string SaveGoal()
    {
        return $"{_goalType}~{_name}~{_description}~{_goalPoints}~{_status}";
    }

    public override void LoadGoal(string[] parts)
    {
        _name = parts[1];
        _description = parts[2];
        _goalPoints = int.Parse(parts[3]);
        _status = bool.Parse(parts[4]);
    }

    // public void AssembleGoal(string name, string description, int goalPoints, bool status)
    // {
        
    // }
}