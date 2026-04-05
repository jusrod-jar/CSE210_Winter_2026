class ChecklistGoal : Goal
{
    private List<(string name, string description, int points, int bonusPoints, int accomplishNum)> _prompts = new List<(string name, string description, int points, int bonusPoints, int accomplishNum)>
    {
    ("Up Early", "Wake up by an early target time and start your day immediately", 50, 100, 5),
    ("Linguistics", "Spend 15 minutes practicing a new language", 20, 50, 14),
    ("Meal Prep", "Portion out your lunches or dinners ahead of time for the upcoming days/week", 60, 150, 4),
    ("Journaling", "Write in a journal reflecting on your day and general thoughts", 15, 30, 10),
    ("Flexibile", "Complete stretching or yoga routine lasting at least 15 minutes", 25, 60, 7)
    };
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
    public override void RandomGoal()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count());
        (_name, _description, _goalPoints, _bonus, _accomplishNum) = _prompts[index];
    }
    public override string ShowcaseRandomGoal()
    {
        return $"\n{"Goal type:", -20} {_goalType}\n{"Name:", -20} {_name}\n{"Description:", -20} {_description}\n{"Points:", -20} {_goalPoints}\n{"Times to Complete:", -20} {_accomplishNum}\n{"Bonus:", -20} {_bonus}";
    }
}