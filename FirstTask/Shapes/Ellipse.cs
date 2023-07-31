using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Shapes
{
    public class Ellipse : Shape
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set;}

        public Ellipse(double majorAxis, double minorAxis)
        {
            Init(majorAxis, minorAxis);
        }

        private void Init(double majorAxis, double minorAxis)
        {
            CheckIfNegative(majorAxis);
            CheckIfNegative(minorAxis);

            MajorAxis = majorAxis;    
            MinorAxis = minorAxis;
        }

        public override double CalculateArea()
        {
            var area = Math.PI * MajorAxis * MinorAxis;
            return area;
        }
        // https://www.cuemath.com/measurement/perimeter-of-ellipse/
        public override double CalculatePerimeter()
        {
            var perimeter = Math.PI * (MajorAxis + MinorAxis);
            return perimeter;
        }
    }
}
