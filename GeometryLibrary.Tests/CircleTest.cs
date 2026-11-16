namespace GeometryLibrary.Tests;

public class CircleTest
{
    [Fact]
    public void CalculateArea_Radius_ReturnsCorrectArea()
    {
        Circle circle = Circle.CreateCircle(5);
        double expectedArea = Math.PI * 25;
        
        double actualArea = circle.CalculateArea();
        
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CreateCircle_RadiusZero_ThrowsArgumentOutOfException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            Circle.CreateCircle(0);
        });
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-5)]
    [InlineData(-10)]
    public void CreateCircle_InvalidRadius_ThrowsArgumentOutOfException(double radius)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Circle.CreateCircle(radius));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void CalculateArea_RadiusRange_ReturnsCorrectArea(double radius)
    {
        Circle circle = Circle.CreateCircle(radius);
        double expectedArea = radius * radius * Math.PI;
        
        double actualArea = circle.CalculateArea();
        
        Assert.Equal(expectedArea, actualArea);
    }
}