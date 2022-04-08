namespace GeometryTwo;

public class Point : Figure
{
    public Point(FigureColor color, FigureState state) : base(color, state)
    {
    }

    public override void Move(int x, int y)
    {
        X = x;
        Y = y;
    }
}
