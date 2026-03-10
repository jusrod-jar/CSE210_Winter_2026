using System;
public class Entry
{
    public DateOnly _currentDate;
    public string _prompt;
    public string _response;
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_currentDate} - {_prompt}");
        Console.WriteLine($"{_response}\n");
    }
}