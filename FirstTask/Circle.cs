using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Init(radius);
        }

        private void Init(double radius)
        {
            CheckIfNegative(radius);
            Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = 2 * Math.PI * Radius;
            return perimeter;
        }

        public override double CalculateArea()
        {
            var area = Math.PI * Radius * Radius;
            return area;
        }
    }
}
