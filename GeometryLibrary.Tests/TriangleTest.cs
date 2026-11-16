namespace GeometryLibrary.Tests;

public class TriangleTest
{
    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 12, 13)]
    [InlineData(6, 8, 10)]
    public void IsRightAngle_ValidSides_ReturnsTrue(
        double a, double b, double c)
    {
        Assert.True(Triangle.CreateTriangle(a, b, c).IsRightAngle());
    }

    [Theory]
    [InlineData(2, 3, 4)]
    [InlineData(5, 5, 5)]
    [InlineData(4, 5, 6)]
    public void IsRightAngle_InvalidSides_ReturnsFalse(
        double a, double b, double c)
    {
        Assert.False(Triangle.CreateTriangle(a, b, c).IsRightAngle());
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1, 2, 10)]
    [InlineData(5, 1, 1)]
    public void CreateTriangle_InvalidSides_ThrowsArgumentException(
        double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => Triangle.CreateTriangle(a, b, c));
    }
    
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 5, 6, 12)]
    [InlineData(6, 8, 10, 24)]
    public void CalculateArea_ValidSides_ReturnsCorrectArea(
        double a, double b, double c, double expectedArea)
    {
        Triangle triangle = Triangle.CreateTriangle(a, b, c);
        
        double actualArea = triangle.CalculateArea();
        
        Assert.Equal(expectedArea, actualArea);
    }
    
    [Theory]
    [InlineData(0, 4, 5)]
    [InlineData(3, 0, 5)]
    [InlineData(3, 4, 0)]
    [InlineData(-3, 4, 5)]
    [InlineData(3, -4, 5)]
    [InlineData(3, 4, -5)]
    public void CreateTriangle_NonPositiveSides_ThrowsArgumentOutOfRangeException(
        double a, double b, double c)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Triangle.CreateTriangle(a, b, c));
    }
    
    [Theory]
    [InlineData(double.NaN, 4, 5)]
    [InlineData(3, double.PositiveInfinity, 5)]
    [InlineData(3, 4, double.NaN)]
    public void CreateTriangle_NonFiniteSides_ThrowsArgumentException(
        double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => Triangle.CreateTriangle(a, b, c));
    }
}