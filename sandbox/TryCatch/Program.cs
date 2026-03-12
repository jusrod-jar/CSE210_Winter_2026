class Program
{
    public static int GetAge()
    {
        int age = 0;
        bool done = false;

        while (!done)
        {
            try
            {
                Console.Write("Please enter your age: ");
                age = int.Parse(Console.ReadLine());
                if (age >= 0 && age <= 125)
                {
                    done = true;
                }
                else
                {
                    throw new Exception("Invalid age");
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
        }
        return age;

    }
    public static void Main(string[] args)
    {
        Console.WriteLine($"Your age is {GetAge()}");
    }
}