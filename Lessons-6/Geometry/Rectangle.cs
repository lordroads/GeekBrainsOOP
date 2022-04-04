namespace Geometry;

public class Rectangle : Point
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height, FigureColor color, FigureState state) : base(color, state)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
    public override string ToString()
    {
        return base.ToString() +
            $"\nWidth - {Width}" +
            $"\nHieght - {Height}";
    }
}
