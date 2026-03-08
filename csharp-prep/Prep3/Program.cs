using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {

Console.Write("What is your number: ");
string numberinput = Console.ReadLine();
int number = int.Parse(numberinput);

int guess = number - 1;

 while (guess != number)
        {
        Console.Write("What is your guess: ");
        string guessinput = Console.ReadLine();
        guess = int.Parse(guessinput);
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("That is correct");
            }
        }

    }
}