namespace GeometryTwo;

public class Circle : Point, IArea
{
    public double Radius { get; set; }
    public Circle(double radius, FigureColor color, FigureState state) : base(color, state)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
    public override string ToString()
    {
        return base.ToString() + $"\nRadius - {Radius}";
    }
}
