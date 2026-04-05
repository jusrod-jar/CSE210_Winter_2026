class Menu
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;
    public int ProcessMenu()
    {
        int initial_choice;
        do
        {
            Console.WriteLine($"\nYou have {_totalPoints} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Random Goal");
            Console.WriteLine("7. Quit");
            Console.Write("Select Choice: ");
            initial_choice = int.Parse(Console.ReadLine());
        } while (initial_choice <= 0 || initial_choice >= 7);

        return initial_choice;
    }

    public void CreateNewGoal()
    {
        int goal_choice;
        do
        {
            Console.WriteLine("\nThe types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which goal would you like to create? ");
            goal_choice = int.Parse(Console.ReadLine());
        } while (goal_choice <= 0 || goal_choice >= 4);

        if (goal_choice == 1)
        {
            SimpleGoal simplegoal = new SimpleGoal();
            simplegoal.CreateGoal();
            _goals.Add(simplegoal);
        }

        else if (goal_choice == 2)
        {
            EternalGoal eternalgoal = new EternalGoal();
            eternalgoal.CreateGoal();
            _goals.Add(eternalgoal);
        }

        else if (goal_choice == 3)
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
        string answer;
        
        Random random = new Random();
        int index = random.Next(1, 3);

        if (index == 1)
        {
            do
            {
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.RandomGoal();
            simpleGoal.ListGoal();

            Console.Write("Would you like to keep this goal or refresh? (y/n): ");
            answer = Console.ReadLine(); 

            } while (answer != "y");
        }

        if (index == 2)
        {
            EternalGoal eternalGoal = new EternalGoal();
            string goal = eternalGoal.RandomGoal();
        }

        if (index == 3)
        {
            ChecklistGoal checklistGoal = new ChecklistGoal();
            string goal = checklistGoal.RandomGoal();
        }

    }
}