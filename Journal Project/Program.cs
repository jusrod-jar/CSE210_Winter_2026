using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!\n");
        Journal journal = new Journal();
        string numResponse = "";
        do {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Receive Motivation");
        Console.WriteLine("6. Quit");
        Console.WriteLine("What would you like to do? ");
        Console.Write("> ");
        numResponse = Console.ReadLine();
        

        if (numResponse == "1")
            {
                Console.WriteLine();
                journal.WriteEntry();
            }

        if (numResponse == "2")
            {
                Console.WriteLine();
                journal.DisplayJournal();
            }
        if (numResponse == "3")
            {
                Console.WriteLine();
                journal.LoadJournal();
            }
        if (numResponse == "4")
            {
                Console.WriteLine();
                journal.SaveJournal();
            }
        if (numResponse == "5")
            {
                Console.WriteLine();
                journal.Motivation();
            }
        } while (numResponse != "6");

        Console.WriteLine("\nThank you for using the journal program.\n");
    }
}