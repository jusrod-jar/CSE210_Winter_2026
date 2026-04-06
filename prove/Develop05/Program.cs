using System;

// I believe that in this assignment I exceeded the requirements and creativity by adding an extra menu option that will display to you
// a random pre-written goal of any type, and prompt you to add the goal to your list or refresh it for a new one.
class Program
{
    static void Main(string[] args)
    {

        Menu menu = new Menu();
        bool active = true;

        while (active)
        {

            int user_choice = menu.ProcessMenu();
            if (user_choice == 1)
            {
                menu.CreateNewGoal();
            }

            else if (user_choice == 2)
            {
                menu.ListGoals();
            }

            else if (user_choice == 3)
            {
                menu.SaveGoals();
            }

            else if (user_choice == 4)
            {
                menu.LoadGoals();
            }

            else if (user_choice == 5)
            {
                menu.RecordEvent();
            }

            else if (user_choice == 6)
            {
                menu.RandomGoal();
            }
                
            else if (user_choice == 7)
            {
                Console.WriteLine("Thank you for using our program");
                active = false;
            }
        }

    }
}