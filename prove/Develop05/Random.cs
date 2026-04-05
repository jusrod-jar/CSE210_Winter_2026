class GetRandom
{
    private Goal _randomGoal;
    private string _answer = "";

    private Goal ReturnRandomGoal()
    {
        Random random = new Random();
        int index = random.Next(1, 4);

        if (index == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.RandomGoal();
            _randomGoal = simpleGoal;
        }

        if (index == 2)
        {
            EternalGoal eternalGoal = new EternalGoal();
            eternalGoal.RandomGoal();
            _randomGoal = eternalGoal;
        }

        if (index == 3)
        {
            ChecklistGoal checklistGoal = new ChecklistGoal();
            checklistGoal.RandomGoal();
            _randomGoal = checklistGoal;
        }
        return _randomGoal;
    }

    public Goal GetRandomGoal()
    {
        do {   
        _randomGoal = ReturnRandomGoal();
        Console.WriteLine(_randomGoal.ShowcaseRandomGoal());
        Console.Write("\nWould you like to refresh this goal? (y/n): ");
        _answer = Console.ReadLine();
        } while (_answer != "n");

        return _randomGoal;
    }
}