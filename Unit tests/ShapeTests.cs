using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapeTests;

[TestClass]
public class ShapeTests
{
    [TestMethod]
    public void Creating_Circle_And_Calculating_Area()
    {
        double radius = 5;
        
        Shape circle = new Circle(radius);
        
        double expected = 78.5;
        double actual = circle.CalculateArea();
        
        Assert.AreEqual(expected, actual, 0.1, "Circle area calculated incorrectly");
    }
    
    [TestMethod]
    public void Creating_Triangle_And_Calculating_Area()
    {
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        
        Shape triangle = new Triangle(side1, side2, side3);
        
        double expected = 6;
        double actual = triangle.CalculateArea();
        
        Assert.AreEqual(expected, actual, 0, "Triangle area calculated incorrectly");
    }

    [TestMethod]
    public void Is_Triangle_Right_Check()
    {
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        
        Triangle triangle = new Triangle(side1, side2, side3);
        
        bool expected = true;
        bool actual = triangle.IsRight();
        
        Assert.AreEqual(expected, actual, "Triangle IsRight check incorrectly");
    }
}