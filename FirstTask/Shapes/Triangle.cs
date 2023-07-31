using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Shapes
{   
    public class Triangle : Shape
    {
        public double FirstSegment { get; set; }
        public double SecondSegment { get; set; }
        public double ThirdSegment { get; set; }

        public Triangle(double firstSegment, double secondSegment, double thirdSegment)
        {
            Init(firstSegment, secondSegment, thirdSegment);    
        }

        private void Init(double firstSegment, double secondSegment, double thirdSegment)
        {
            CheckIfNegative(firstSegment);
            CheckIfNegative(secondSegment);
            CheckIfNegative(thirdSegment);

            var firstCheck = firstSegment + secondSegment > thirdSegment;
            var secondCheck = secondSegment + thirdSegment > firstSegment;
            var thirdCheck = firstSegment + thirdSegment > secondSegment;

            if (firstCheck && secondCheck && thirdCheck)
            {
                FirstSegment = firstSegment;
                SecondSegment = secondSegment;
                ThirdSegment = thirdSegment;
            }
            else
            {
                throw new ArgumentException("The sides of triangle have invalid value.");
            }
        }

        public override double CalculatePerimeter()
        {
            var perimeter = FirstSegment + SecondSegment + ThirdSegment;
            return perimeter;
        }

        public override double CalculateArea()
        {
            var semiPerimeter = CalculatePerimeter() / 2;
            var underRootExpression = semiPerimeter * (semiPerimeter - FirstSegment) * (semiPerimeter - SecondSegment) * (semiPerimeter - ThirdSegment);
            var area = Math.Sqrt(underRootExpression);
            return area;
        }
    }
}
