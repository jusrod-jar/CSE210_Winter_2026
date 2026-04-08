using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("538 S 2nd W", "Rexburg", "ID", "USA");
        Address address2 = new Address("1778 Country Squire", "Dade City", "FL", "USA");
        Address address3 = new Address("98 Rothschild Row", "Beverly Hills", "CA", "USA");

        Lecture lecture = new Lecture("Grad School", "A deep dive into your future in graduate school.", "April 10", "2:00 PM", address1, "Dr. Smith", 100);
        Reception reception = new Reception("Tech Mix", "Networking event for developers.", "May 15", "6:00 PM", address2, "rsvp@techmixguy.com");
        Gathering gathering = new Gathering("Company Hangout", "Company wide event for a lil break", "July 4", "12:00 PM", address3, "Sunny and 75 degrees");

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(lecture.GetStandard());
        Console.WriteLine(lecture.GetFull());
        Console.WriteLine(lecture.GetShort());

        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine(reception.GetStandard());
        Console.WriteLine(reception.GetFull());
        Console.WriteLine(reception.GetShort());

        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine(gathering.GetStandard());
        Console.WriteLine(gathering.GetFull());
        Console.WriteLine(gathering.GetShort());
    }
}