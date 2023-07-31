using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstTask.ShapeCreators;
using FirstTask.Shapes;

namespace FirstTask
{
    public static class ShapeFactory
	{
		private static Dictionary<string, IShapeCreator> _shapes = new Dictionary<string, IShapeCreator>();

		public static void RegisterShape(string shapeKey, IShapeCreator shapeCreator)
		{
			if (!_shapes.ContainsKey(shapeKey)) 
			{
				_shapes.Add(shapeKey, shapeCreator);
			}
		}

		public static Shape Create(string shapeKey)
		{
			if (_shapes.ContainsKey(shapeKey))
			{
				var shape = _shapes[shapeKey].Create();
				return shape;
			}
			throw new ArgumentException("Incorrect shape key");
		}

	}
}
