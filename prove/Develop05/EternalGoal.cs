class EternalGoal : Goal
{
    private List<(string name, string description, int points)> prompts = new List<(string name, string description, int points)>
    {
    ("Iron", "Complete a one-hour workout at the gym", 50),
    ("Literacy", "Read at least 20 pages or one full chapter of a book", 40),
    ("Mindfulness", "Spend 10 minutes in silent meditation", 20),
    ("Hydration", "Drink 8 glasses of water throughout a single day", 30),
    ("Daily Walk", "Take a 30-minute walk outside to get some fresh air", 50)
    };
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
    public override void RandomGoal()
    {
        Random random = new Random();
        int index = random.Next(1, 5);
        (_name, _description, _goalPoints) = prompts[index];
    }
    public override string ShowcaseRandomGoal()
    {
        return $"\n{"Goal type:", -20} {_goalType}\n{"Name:", -20} {_name}\n{"Description:", -20} {_description}\n{"Points:", -20} {_goalPoints}";
    }
}