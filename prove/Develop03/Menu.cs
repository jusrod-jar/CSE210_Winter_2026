class Menu
{
    public void DisplayMenu()
    {
        string userInput = "";

        Scripture scripture = new Scripture();
        Console.Clear();
        Console.WriteLine("\nA random scripture has been provided for you.");
        scripture.SetRandomScripture();

        do
        {
            Console.WriteLine($"\n{scripture.DisplayScripture()}");

            Console.WriteLine("\nPlease press enter to continue or type \"quit\" to finish.");
            Console.WriteLine("Else, enter \"new\" to get a new random scripture.");
            userInput = Console.ReadLine();

            switch (userInput)
            {

                case "":
                    if (scripture.IsAllHidden())
                    {
                        Console.Clear();
                        userInput = "quit";
                    }

                    else
                    {
                    Console.Clear();
                    scripture.HideRandomWords(3);
                    }
                    break;

                case "new":
                    Console.Clear();
                    scripture.SetRandomScripture();
                    break;

                case "quit":
                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        } while (userInput != "quit");

        Console.WriteLine("\nThank you for choosing this program.\n");
    }
}