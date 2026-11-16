namespace GeometryLibrary;

public sealed class Circle : IShape
{
    private Circle(double radius)
    {
        Radius = radius;
    }
    
    public double Radius { get; }

    public static Circle CreateCircle(double radius)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(radius,"radius");

        if (!double.IsFinite(radius))
        {
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be a positive number");
        }
        
        return new Circle(radius);
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}