namespace Shapes;

public class Triangle : Shape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public Triangle()
    {
        Side1 = Side2 = Side3 = default;
    }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public override double CalculateArea()
    {
        double p = (Side1 + Side2 + Side3) / 2;
        Area = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        return Area;
    }

    public bool IsRight()
    {
        return (Side1 == Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side3, 2))
                || Side2 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2))
                || Side3 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2)));
    }
}