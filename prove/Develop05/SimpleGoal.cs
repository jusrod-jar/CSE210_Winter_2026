class SimpleGoal : Goal
{
    private List<(string name, string description, int points)> _prompts = new List<(string name, string description, int points)>
    {
    ("Cleaning", "Thoroughly clean one room or area in your living space", 50),
    ("Epicurean", "Cook a brand new recipe from scratch", 40),
    ("Budgeting", "Draft a budget for the upcoming month", 60),
    ("Detox", "Spend one entire day completely free of social media and recreational screen time", 100),
    ("Shower", "Go take a shower because I can smell you through the screen", 50)
    };
    public SimpleGoal(): base("Simple")
    {
        
    }

    public override void CreateGoal()
    {
        base.SetBaseProperties();
    }
    public override int RecordEvent()
    {
        _status = true;
        return _goalPoints;
    }
    public override void LoadGoal(string[] parts)
    {
        _name = parts[1];
        _description = parts[2];
        _goalPoints = int.Parse(parts[3]);
        _status = bool.Parse(parts[4]);
    }

    public override void RandomGoal()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count());
        (_name, _description, _goalPoints) = _prompts[index];
    }
}