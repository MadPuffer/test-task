namespace Shapes;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle()
    {
        Radius = default;
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        Area = Math.PI * Math.Pow(Radius, 2);
        return Area;
    }
}