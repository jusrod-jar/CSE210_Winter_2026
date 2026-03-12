class Program
{
    public static void Main(string[] args)
    {
        Angle angle1 = new Angle(180);
        
        Console.WriteLine(angle1.GetRadians());
        
        Console.WriteLine(angle1.GetDegrees());

        angle1.SetDegrees(270);

        Console.WriteLine(angle1.GetRadians());
    }
}
