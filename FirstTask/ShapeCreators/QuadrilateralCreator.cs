using FirstTask.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ShapeCreators
{
	public class QuadrilateralCreator : IShapeCreator
	{
		public Shape Create()
		{
			Console.WriteLine("Please input four sides of a quadrilateral");
			var sides = Console.ReadLine().Split(" ");
			double side1, side2, side3, side4;
			Console.WriteLine("Please input opposing angles (angle ab and angle cd)");
			var angles = Console.ReadLine().Split(" ");
			double angle1, angle2;
			try
			{
				side1 = Convert.ToDouble(sides[0]);
				side2 = Convert.ToDouble(sides[1]);
				side3 = Convert.ToDouble(sides[2]);
				side4 = Convert.ToDouble(sides[3]);

				angle1 = Convert.ToDouble(angles[0]);
				angle2 = Convert.ToDouble(angles[1]);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("The sides or angles have invalid value");
				throw;
			}
			var quadrilateral = new Quadrilateral(side1, side2, side3, side4, angle1, angle2);
			return quadrilateral;
		}
	}
}
