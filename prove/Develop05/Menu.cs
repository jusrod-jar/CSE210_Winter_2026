class Menu
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;
    public int ProcessMenu()
    {
        int initialChoice;
        do
        {
            Console.WriteLine($"\nYou have {_totalPoints} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Random Goal");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
            initialChoice = int.Parse(Console.ReadLine());
        } while (initialChoice <= 0 || initialChoice >= 8);

        return initialChoice;
    }

    public void CreateNewGoal()
    {
        int goalChoice;
        do
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            goalChoice = int.Parse(Console.ReadLine());
        } while (goalChoice <= 0 || goalChoice >= 4);

        if (goalChoice == 1)
        {
            SimpleGoal simplegoal = new SimpleGoal();
            simplegoal.CreateGoal();
            _goals.Add(simplegoal);
        }

        else if (goalChoice == 2)
        {
            EternalGoal eternalgoal = new EternalGoal();
            eternalgoal.CreateGoal();
            _goals.Add(eternalgoal);
        }

        else if (goalChoice == 3)
        {
            ChecklistGoal checklistgoal = new ChecklistGoal();
            checklistgoal.CreateGoal();
            _goals.Add(checklistgoal);
        }
    }
    public void ListGoals()
    {
        if (_goals.Count() == 0)
        {
            Console.WriteLine("\nYou currently have no goals.");
        }

        else
        {
            Console.WriteLine("\nYour goals are:");

            for (int i = 0; i < _goals.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].ListGoal()}");
            }
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What would you like to save this journal as? ");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename you would like to load? ");
        string filename = Console.ReadLine();
        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            if (int.TryParse(parts[0], out int result))
            {
                _totalPoints = result;
            }

            else if (parts[0] == "Simple")
            {
                SimpleGoal simpleGoal = new SimpleGoal();

                simpleGoal.LoadGoal(parts);
                _goals.Add(simpleGoal);
            }

            else if (parts[0] == "Eternal")
            {
                EternalGoal eternalGoal = new EternalGoal();

                eternalGoal.LoadGoal(parts);
                _goals.Add(eternalGoal);
            }

            else if (parts[0] == "Checklist")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal();

                checklistGoal.LoadGoal(parts);
                _goals.Add(checklistGoal);
            }

        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nYour goals are:");

        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("\nWhich goal did you accomplish? ");
        int accomplish = int.Parse(Console.ReadLine());

        if (_goals[accomplish - 1].DisplayStatus() == "X")
        {
            Console.WriteLine("You have already completed this goal.");
        }

        else
        {
            int pointsEarned = _goals[accomplish - 1].RecordEvent();
            _totalPoints += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        }
    }

    public void RandomGoal()
    {
        Console.WriteLine("\nSimple, Eternal, and Checklist goals are present within the pool. Keep refreshing to find a goal you want.");
        GetRandom getRandom = new GetRandom();
        _goals.Add(getRandom.GetRandomGoal());
    }
}