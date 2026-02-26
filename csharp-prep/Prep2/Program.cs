using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade: ");
        string sgrade = Console.ReadLine();
        int grade = int.Parse(sgrade);

        if (grade >= 90 && grade <= 105)
        {
            Console.WriteLine("You have an A");
        }
        else if (grade >= 80 && grade <= 89)
        {
            Console.WriteLine("YOu have a B");
        }
        else if (grade >= 70 && grade <= 79)
        {
            Console.WriteLine("You have a C");
        }
        else if (grade >= 60 && grade <= 69)
        {
            Console.WriteLine("You have a D");
        }
        else
        {
            Console.WriteLine("You have an F");
        }
    }   
}