using GeometryTwo;

List<Figure> figures = new List<Figure>()
{
    new Point(FigureColor.Red, FigureState.Visible),
    new Circle(100, FigureColor.Green, FigureState.Visible),
    new Rectangle(100, 250, FigureColor.Blue, FigureState.Visible)
};

/*
 * Из-за введении абстрактного класс, 
 * кукую-то Fifure нельзя создать, 
 * что являеется более логичнее.
 * 
 * Figure someFigure = new Figure();
 */

foreach(Figure figure in figures)
{
    Console.WriteLine(figure.GetType());
    figure.Move(5, 10);
    Console.WriteLine(figure);
    if (figure is IArea)
    {
        IArea area = (IArea)figure;
        Console.WriteLine($"Area - {area.CalculateArea()}");
    }
    Console.WriteLine();
}

