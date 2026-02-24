using System;

class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");
        string firstName;
        string lastName;

        Console.Write("\nWhat is your first name: ");
        firstName = Console.ReadLine();

        Console.WriteLine(firstName);

        Console.Write("What is your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}");
    }
}