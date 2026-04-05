class ChecklistGoal : Goal
{
    private int _bonus;
    private int _accomplishNum;
    private int _accomplishCounter = 0;
    public ChecklistGoal() : base("Checklist")
    {
        
    }
    public override void CreateGoal()
    {
        base.SetBaseProperties();

        Console.Write("How many times do you need to accomplish this goal for a bonus? ");
        _accomplishNum = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it the set amount of times? ");
        _bonus = int.Parse(Console.ReadLine());
    }
    public override string ListGoal()
    {

        return $"[{DisplayStatus()}] {_name} ({_description}) (Completed {_accomplishCounter}/{_accomplishNum}) - {_goalType}";
    }

    public override int RecordEvent()
    {
        _accomplishCounter++;

        if (_accomplishCounter >= _accomplishNum)
        {
            _status = true;
            return _goalPoints + _bonus;
        }

        return _goalPoints;
    }
    public override string SaveGoal()
    {
        return $"{_goalType}~{_name}~{_description}~{_goalPoints}~{_bonus}~{_accomplishNum}~{_accomplishCounter}";
    }
    public override void LoadGoal(string[] parts)
    {
        _name = parts[1];
        _description = parts[2];
        _goalPoints = int.Parse(parts[3]);
        _bonus = int.Parse(parts[4]);
        _accomplishNum = int.Parse(parts[5]);
        _accomplishCounter = int.Parse(parts[6]);

        if (_accomplishCounter >= _accomplishNum)
        {
            _status = true;
        }
    }

}