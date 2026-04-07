class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing")
    {
        
    }
    
    protected override void DisplayActivityDescription()
    {
        Console.WriteLine("\nThis activity will help you relax by walking your through breathing in and out slowly." +
        " Clear your mind and focus on your breathing.");
    }

    protected override void RunActivity()
    {
        int remainder = GetRemainder(_seconds);
        GetReady(remainder);

        int count = GetCount(10);

        for (int i = 0; i < count; i++)
        {
            Console.Write("\nBreathe in...");
            Countdown(4);

            Console.Write("\nNow breathe out...");
            Countdown(6);
            Console.WriteLine();
        }
        _seconds = remainder + (count * 10);
    }
    
    private int GetRemainder(int seconds)
    {
        int remainder = seconds % 10;

        if (remainder <= 3)
        {
            remainder = 4;
        }
        else if (remainder >= 7)
        {
            remainder = 6;
        }

        return remainder;
    }
}