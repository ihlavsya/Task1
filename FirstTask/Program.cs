// See https://aka.ms/new-console-template for more information
using FirstTask;
using FirstTask.ShapeCreators;
using FirstTask.Shapes;

Console.WriteLine("Hello, World!");

ShapeFactory.RegisterShape("Circle", new CircleCreator());
ShapeFactory.RegisterShape("Ellipse", new EllipseCreator());
ShapeFactory.RegisterShape("Triangle", new TriangleCreator());
ShapeFactory.RegisterShape("Quadrilateral", new QuadrilateralCreator());

while (true)
{
	Console.WriteLine("Please choose the shape: Circle, Ellipse, Triangle, Quadrilateral");
	var shape = Console.ReadLine();
	Shape createdShape;
	try
	{
		createdShape = ShapeFactory.Create(shape);
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

public delegate Shape CreateShape();
