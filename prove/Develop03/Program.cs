using System;

// This program exceeds the core requirements and goes above and beyond with the addition
// of an extra option within the menu that will create a random verse for you using the bom.csv if you chose it.
// This random verse DOES have a chance to create multi-verse scriptures as well as single-verse ones.
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();        
    }
}