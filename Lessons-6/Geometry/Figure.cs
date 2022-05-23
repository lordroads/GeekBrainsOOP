namespace Geometry;

public class Figure
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public FigureColor Color { get; private set; }
    public FigureState State { get; private set; }

    public Figure(FigureColor color, FigureState state)
    {
        Color = color;
        State = state;
    }

    public void Move(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"Coordinates: {X},{Y}\nColor: {Color}\nVisibility state: {State}";
    }
}
