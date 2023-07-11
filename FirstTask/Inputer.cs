using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public static class Inputer
    {
        public static Circle CreateCircle()
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

        public static Ellipse CreateEllipse()
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

        public static Triangle CreateTriangle()
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
        // https://math.stackexchange.com/questions/713435/geometry-question-regarding-existence-of-a-quadrilateral
        public static Quadrilateral CreateQuadrilateral()
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
            catch(FormatException ex)
            {
                Console.WriteLine("The sides or angles have invalid value");
                throw;
            }
            var quadrilateral = new Quadrilateral(side1, side2, side3, side4, angle1, angle2);
            return quadrilateral;
        }
    }
}
