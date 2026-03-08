using System;
using System.Configuration.Assemblies;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    // static void Main(string[] args)
    // {
    // }

    // public static void passByValue(int a)
    // {
    //     a++;
    //     Console.WriteLine($"In the value function {a}");
    // }

    // public static void passByRef(ref int x)
    // {
    //     x ++;
    //     Console.WriteLine($"In the ref function {x}");
    // }

    // public static void passByOut(out int y)
    // {
    //     y = 10;
    // }

    static void Main(string[] args)
    {

        Console.WriteLine("Circle");

        Circle myCircle = new Circle();

        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetRadius());

        Circle myCircle2 = new Circle();

        myCircle.SetRadius(100);
        Console.WriteLine(myCircle.GetRadius());


    //     int x = 20;
    //     Console.WriteLine($"In the main 1: {x}");

    //     passByValue(x);
    //     Console.WriteLine($"In the main 2: {x}");

    //     passByRef(ref x);
    //     Console.WriteLine($"In the main 3: {x}");

    //     int z;
    //     passByOut(out z);
    //     Console.WriteLine(z);
    }

}