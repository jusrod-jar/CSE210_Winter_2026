
class Circle
{
    private double _radius;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Invalid Radius, must be a positive value.");
            _radius = 0;
        }

        else
            _radius = radius;
    }
}