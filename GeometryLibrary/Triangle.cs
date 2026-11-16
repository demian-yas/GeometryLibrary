namespace GeometryLibrary;

public sealed class Triangle : IShape
{
    private Triangle(double a, double b, double c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }
    
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    private double SemiPerimeter
    {
        get
        {
            return (SideA + SideB + SideC) / 2;
        }
    }

    public static Triangle CreateTriangle(double a, double b, double c)
    {
        if (!double.IsFinite(a) || !double.IsFinite(b) || !double.IsFinite(c))
        {
            throw new ArgumentException("The provided sides do not form a valid triangle.");
        }
        
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(a, nameof(a));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(b, nameof(b));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(c, nameof(c));


        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("The provided sides do not form a valid triangle.");
        }
        
        return new Triangle(a, b, c);
    }

    public bool IsRightAngle()
    {
        double[] sides = [SideA, SideB, SideC];
        
        Array.Sort(sides);
        
        double firstLeg = sides[0];
        double secondLeg = sides[1];
        double hypotenuse = sides[2];

        double left = firstLeg / hypotenuse;
        double right = secondLeg / hypotenuse;

        double epsilon = 1e-12;
        
        return Math.Abs(left * left + right * right - 1.0) < epsilon;
    }
    
    public double CalculateArea()
    {
        return Math.Sqrt(SemiPerimeter * (SemiPerimeter - SideA) * (SemiPerimeter - SideB) * (SemiPerimeter - SideC));
    }
}