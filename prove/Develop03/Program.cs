using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Scripture scripture = new Scripture();
        Console.WriteLine("\nAn initial scripture has been provided for you.");
        do
        {
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine("\nType 'new' for a new random scripture.");
            Console.WriteLine("Type 'input' to input your own scripture.");
            Console.WriteLine("Type 'quit' to quit menu.");
            Console.WriteLine("Else hit enter to continue.");
            choice = Console.ReadLine();

            if (choice == "new")
            {
                
            }
            else if (choice == "input")
            {
                
            }
            else if (choice == "")
            {
                Console.Clear();
            }
            
        } while (choice != "quit");
    }
}