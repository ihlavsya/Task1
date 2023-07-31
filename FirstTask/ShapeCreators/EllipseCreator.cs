using FirstTask.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ShapeCreators
{
	public class EllipseCreator : IShapeCreator
	{
		public Shape Create()
		{
			Console.WriteLine("Please input the major and minor axes of an ellipse");
			var axes = Console.ReadLine().Split(" ");
			double majorAxis, minorAxis;
			try
			{
				majorAxis = Convert.ToDouble(axes[0]);
				minorAxis = Convert.ToDouble(axes[1]);
			}
			catch (FormatException)
			{
				Console.WriteLine("The major or minor axes have invalid value");
				throw;
			}
			var ellipse = new Ellipse(majorAxis, minorAxis);
			return ellipse;
		}
	}
}
