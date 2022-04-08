namespace GeometryTwo;

public class Rectangle : Point, IArea
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height, FigureColor color, FigureState state) : base(color, state)
    {
        Height = height;
        Width = width;
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
