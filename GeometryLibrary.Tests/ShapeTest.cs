namespace GeometryLibrary.Tests;

public class ShapeTest
{
    [Fact]
    public void CalculateArea_DifferentShapes_ReturnsCorrectAreas()
    {
        IShape circle = Circle.CreateCircle(5);
        IShape triangle = Triangle.CreateTriangle(3, 4, 5);

        double circleArea = 25 * Math.PI;
        double triangleArea = 6;

        Assert.Equal(circleArea, circle.CalculateArea());
        Assert.Equal(triangleArea, triangle.CalculateArea());
    }
}