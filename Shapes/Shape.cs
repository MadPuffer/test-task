namespace Shapes;

public abstract class Shape
{
    public double Area { get; private protected set; }

    public abstract double CalculateArea();
}