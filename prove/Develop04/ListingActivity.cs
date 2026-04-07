class ListingActivity : Activity
{
    List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing")
    {
        
    }

    protected override void DisplayActivityDescription()
    {
        Console.WriteLine("\nThis activity will help you reflect on the good things in your life" +
        " by having you list as many things as you can in a certain area.");
    }

    protected override void RunActivity()
    {
        GetReady();
        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        Console.WriteLine($"\n --- {GetRandomPrompt(_prompts)} --- ");
        Console.Write("\nYou may begin in: ");
        Countdown();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_seconds);

        int responseCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            responseCount++;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {responseCount} items!");
    }
}