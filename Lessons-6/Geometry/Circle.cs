namespace Geometry;

public class Circle : Point
{
    public double Radius { get; set; }
    public Circle(int radius, FigureColor color, FigureState state) : base(color, state)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI*Math.Pow(Radius, 2);
    }
    public override string ToString()
    {
        return base.ToString() + $"\nRadius - {Radius}";
    }
}
