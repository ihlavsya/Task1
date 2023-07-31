using FirstTask.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ShapeCreators
{
	public class CircleCreator : IShapeCreator
	{
		public Shape Create()
		{
			Console.WriteLine("Please input the radius of a triangle");
			var radiusStr = Console.ReadLine();
			double radius;
			try
			{
				radius = Convert.ToDouble(radiusStr);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("The radius has invalid value");
				throw;
			}
			var circle = new Circle(radius);
			return circle;
		}
	}
}
