using Geometry;

Figure figure = new Figure(FigureColor.Red, FigureState.Visible);
Point point = new Point(FigureColor.Green, FigureState.Invisible);
Circle circle = new Circle(10, FigureColor.Blue, FigureState.Visible);
Rectangle rectangle = new Rectangle(5, 10, FigureColor.Blue, FigureState.Visible);

figure.Move(1, 1);
point.Move(1, 2);
circle.Move(1, 3);
rectangle.Move(1, 4);

Console.WriteLine("Figure:");
Console.WriteLine(figure);
Console.WriteLine();
Console.WriteLine("Point:");
Console.WriteLine(point);
Console.WriteLine();
Console.WriteLine("Circle:");
Console.WriteLine(circle);
Console.WriteLine();
Console.WriteLine("Rectangel:");
Console.WriteLine(rectangle);
