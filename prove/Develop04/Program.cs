using System;

// For exceeding requirements I added a quality of life option that allows the user to immediately repeat
// the experience using the same amount of seconds not needing to go back to the menu and choose that activity and
// input everything else it just repeats. This creates a seamless loop for anyone who wants to do the same activity.

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
    }
}