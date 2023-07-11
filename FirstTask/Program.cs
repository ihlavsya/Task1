// See https://aka.ms/new-console-template for more information
using FirstTask;

Console.WriteLine("Hello, World!");
var shapesDict = new Dictionary<string, CreateShape>();

shapesDict.Add("Circle", Inputer.CreateCircle);
shapesDict.Add("Ellipse", Inputer.CreateEllipse);
shapesDict.Add("Triangle", Inputer.CreateTriangle);
shapesDict.Add("Quadrilateral", Inputer.CreateQuadrilateral);

while (true)
{
    Console.WriteLine("Please choose the shape: Circle, Ellipse, Triangle, Quadrilateral");
    var shape = Console.ReadLine();
    if (!shapesDict.ContainsKey(shape))
    {
        Console.WriteLine("Smth wrong with the input. Please try again");
        continue;
    }
    else
    {
        Shape createdShape;
        try
        {
            createdShape = shapesDict[shape]();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message} Please try again");
            continue;
        }
        var perimeter = createdShape.CalculatePerimeter();
        var area = createdShape.CalculateArea();
        Console.WriteLine($"Perimeter: {perimeter}, area: {area}");
    }
}

public delegate Shape CreateShape();
