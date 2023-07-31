using FirstTask.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ShapeCreators
{
	public class TriangleCreator : IShapeCreator
	{
		public Shape Create()
		{
			Console.WriteLine("Please input three sides of a triangle");
			var sides = Console.ReadLine().Split(" ");
			double side1, side2, side3;
			try
			{
				side1 = Convert.ToDouble(sides[0]);
				side2 = Convert.ToDouble(sides[1]);
				side3 = Convert.ToDouble(sides[2]);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("The sides of triangle have invalid value");
				throw;
			}
			var triangle = new Triangle(side1, side2, side3);
			return triangle;
		}
	}
}
