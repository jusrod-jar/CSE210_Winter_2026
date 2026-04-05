class EternalGoal : Goal
{
    private List<(string name, string description, int points)> _prompts = new List<(string name, string description, int points)>
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
    public override int RecordEvent()
    {
        return _goalPoints;
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
        int index = random.Next(0, _prompts.Count());
        (_name, _description, _goalPoints) = _prompts[index];
    }

}