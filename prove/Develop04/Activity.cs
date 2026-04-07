abstract class Activity
{
    private Random _random = new Random();
    protected string _activityType;
    protected int _seconds;
    protected const int DefaultTime = 5;

    public Activity(string activityType)
    {
        _activityType = activityType;
    }

    public void DisplayActivity()
    {
        string repeat = "n";

        Console.Clear();
        DisplayActivityIntroduction();
        do
        {
        RunActivity();
        DisplayActivityCompletion();
        Console.Write("Would you like to repeat the activity with the same time? (y/n): ");
        repeat = Console.ReadLine();

        } while (repeat != "n");
    }

    private void DisplayActivityIntroduction()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_activityType} Activity.");

        DisplayActivityDescription();

        Console.Write("\nHow long, in seconds, would you like your session? ");
        _seconds = int.Parse(Console.ReadLine());
    }

    private void DisplayActivityCompletion()
    {
        Console.WriteLine("\nWell done.");
        SpinnerAnimation(DefaultTime);

        Console.WriteLine($"\nYou have completed {_seconds} seconds of the {_activityType} activity.");
        SpinnerAnimation(DefaultTime);
        Console.Clear();
    }

    protected string GetRandomPrompt(List<string> strings)
    {
        int randomIndex = _random.Next(0, strings.Count);
        return strings[randomIndex];
    }

    protected int GetCount(int multiple)
    {
        int count = _seconds / multiple;
        
        if (count < 1)
        {
            count = 1;
        }
        return count;
    }

    protected void GetReady(int seconds=DefaultTime)
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        SpinnerAnimation(seconds);
    }

    protected void SpinnerAnimation(int seconds=DefaultTime)
    {
        List<string> spinnerFrames = new List<string>()
        {
            "|", "/", "-", "\\",
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"{spinnerFrames[i]} ");
            Thread.Sleep(400);
            Console.Write("\b\b \b");

            i++;
            if (i >= spinnerFrames.Count)
            {
                i = 0;
            }
        }
    }
    
    protected void Countdown(int seconds=DefaultTime)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b \b");
        }
    }

    protected abstract void DisplayActivityDescription();
    protected abstract void RunActivity();
}