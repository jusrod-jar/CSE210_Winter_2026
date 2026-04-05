abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _status;
    protected string _goalType;


    public Goal(string type)
    {
        _name = "";
        _description = "";
        _status = false;
        _goalPoints = 0;
        _goalType = type;
    }

    protected void SetBaseProperties()
    {
        SetName();
        SetDescription();
        SetPoints();
    }
    public string DisplayStatus()
    {
        // Returns either an X or nothing
        if (_status == true)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }
    private void SetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
    }
    private void SetDescription()
    {
        Console.Write("What is a short description of your goal? ");
        _description = Console.ReadLine();
    }
    private void SetPoints()
    {
        Console.Write("Amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }
    public string GetName()
    {
        return _name;
    }

    public abstract string ListGoal();
    public abstract void CreateGoal();
    public abstract int RecordEvent();
    public abstract string SaveGoal();
    public abstract void LoadGoal(string[] parts);
    public abstract void RandomGoal();
    public abstract string ShowcaseRandomGoal();
}