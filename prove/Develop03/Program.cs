using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Scripture random_scripture = new Scripture();
        Word word = new Word();
        string chosen_scripture = random_scripture.GetNewScripture();
        Console.WriteLine("\nAn initial scripture has been provided for you.");
        do
        {
            Console.WriteLine(chosen_scripture);

            Console.WriteLine("\nType 'new' for a new random scripture.");
            Console.WriteLine("Type 'input' to input your own scripture.");
            Console.WriteLine("Type 'quit' to quit menu.");
            Console.WriteLine("Else hit enter to continue.");
            choice = Console.ReadLine();

            if (choice == "new")
            {
                Console.Clear();
                chosen_scripture = random_scripture.GetNewScripture();
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