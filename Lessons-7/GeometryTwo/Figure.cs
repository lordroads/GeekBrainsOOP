namespace GeometryTwo;

public abstract class Figure
{
    public int X { get; protected set; }
    public int Y { get; protected set; }
    public FigureColor Color { get; set; }
    public FigureState State { get; protected set; }

    public Figure(FigureColor color, FigureState state)
    {
        Color = color;
        State = state;
    }

    public abstract void Move(int x, int y);
    public override string ToString()
    {
        return $"Coordinates: {X},{Y}\nColor: {Color}\nVisibility state: {State}";
    }
}
