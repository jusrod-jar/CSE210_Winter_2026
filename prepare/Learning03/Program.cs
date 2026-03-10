using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction fraction5 = new Fraction();
        Random random = new Random();

        for (int i = 0; i < 20; i++)
        {
        int topValue = random.Next(0, 20);
        int bottomValue = random.Next(0, 20);

        fraction5.SetTop(topValue);
        fraction5.SetBottom(bottomValue);

        Console.WriteLine($"Fraction: {i + 1} String: {fraction5.GetFractionString()} Decimal: {fraction5.GetDecimalValue():F3}");
        }
          
        // This is all test code

        // Fraction none = new Fraction();
        // Fraction ftop = new Fraction(6);
        // Fraction both = new Fraction(6, 7);

        // none.SetBottom(8);
        // int bottom = none.GetBottom();
        // Console.WriteLine(bottom);

        // none.SetTop(8);
        // int top = none.GetTop();
        // Console.WriteLine(top);

        // Fraction fraction1 = new Fraction();
        // Fraction fraction2 = new Fraction(5);
        // Fraction fraction3 = new Fraction(3, 4);
        // Fraction fraction4 = new Fraction(1, 3);

        // string fract1 = fraction1.GetFractionString();
        // double decFract1 = fraction1.GetDecimalValue();
        // Console.WriteLine(fract1);
        // Console.WriteLine(decFract1);
        
        // string fract2 = fraction2.GetFractionString();
        // double decFract2 = fraction2.GetDecimalValue();
        // Console.WriteLine(fract2);
        // Console.WriteLine(decFract2);

        // string fract3 = fraction3.GetFractionString();
        // double decFract3 = fraction3.GetDecimalValue();
        // Console.WriteLine(fract3);
        // Console.WriteLine(decFract3);

        // string fract4 = fraction4.GetFractionString();
        // double decFract4 = fraction4.GetDecimalValue();
        // Console.WriteLine(fract4);
        // Console.WriteLine(decFract4);

    }
}