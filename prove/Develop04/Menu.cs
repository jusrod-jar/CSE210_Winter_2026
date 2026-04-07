class Menu
{
    public void DisplayMenu()
    {
        string userChoice = "";

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select choice from the menu: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayActivity();
                    break;
                
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.DisplayActivity();
                    break;
                
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayActivity();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("\n --- Thank you for using this program. --- \n");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nThat is not a valid input. Try again.");
                    break;
            }
        } while (userChoice != "4");
    }
}