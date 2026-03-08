using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // List<string> words = new List<string>();

// foreach (string word in words)// Equivalent to for i in ___ 
// {
//     Console.WriteLine(word);
// }

// for (int i = 0; i < words.Count; i++) // Same thing but accessing the index
// {
//     Console.WriteLine(words[i]);
// }
double num = 0;
double total = 0;
double biggest = float.NegativeInfinity;
double smallest = float.PositiveInfinity;

List<double> numbers = new List<double>();
Console.WriteLine("Enter a list of numbers, type 0 when finished.");

do
        {
            Console.Write("Enter number: ");
            string numinput = Console.ReadLine();
            num = double.Parse(numinput);

            numbers.Add(num);
            total = num + total;
            if (biggest < num)
            {
                biggest = num;
            }

            if (num > 0 && num < smallest)
            {
                smallest = num;
            }

        } while (num != 0);


        Console.WriteLine($"The sum is: {total}");
        double average = total / (numbers.Count - 1);
        Console.WriteLine($"The average is: {average:F3}");
        Console.WriteLine($"The biggest number is: {biggest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        Console.WriteLine();
        Console.WriteLine("The sorted list:");
        numbers.Sort();
        foreach (float number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}