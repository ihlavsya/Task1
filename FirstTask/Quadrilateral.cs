using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class Quadrilateral : Shape
    {
        public double FirstSegment { get; set; }
        public double SecondSegment { get; set; }
        public double ThirdSegment { get; set; }
        public double FourthSegment { get; set; }
        public double FirstAngle { get; set; }
        public double SecondAngle { get; set; }

        public Quadrilateral(double firstSegment, double secondSegment, double thirdSegment, double fourthSegment, double firstAngle, double secondAngle)
        {
            Init(firstSegment, secondSegment, thirdSegment, fourthSegment, firstAngle, secondAngle);
        }

        private void Init(double firstSegment, double secondSegment, double thirdSegment, double fourthSegment, double firstAngle, double secondAngle)
        {
            CheckIfNegative(firstSegment);
            CheckIfNegative(secondSegment);
            CheckIfNegative(thirdSegment);
            CheckIfNegative(fourthSegment);

            CheckIfNegative(firstAngle);
            CheckIfNegative(secondAngle);

            var ifValid = CheckIfSuchQuadrilateralExists(firstSegment, secondSegment, thirdSegment, fourthSegment);
            if (ifValid)
            {
                FirstSegment = firstSegment;
                SecondSegment = secondSegment;
                ThirdSegment = thirdSegment;
                FourthSegment = fourthSegment;
                FirstAngle = firstAngle;
                SecondAngle = secondAngle;
            }
        }
        // https://math.stackexchange.com/questions/713435/geometry-question-regarding-existence-of-a-quadrilateral
        public bool CheckIfSuchQuadrilateralExists(double firstSegment, double secondSegment, double thirdSegment, double fourthSegment)
        {
            var firstExpression = Math.Pow(firstSegment, 2) - 2 * firstSegment * secondSegment * Math.Cos(FirstAngle) - Math.Pow(secondSegment, 2);
            var secondExpression = Math.Pow(thirdSegment, 2) - 2 * thirdSegment * fourthSegment * Math.Cos(SecondAngle) - Math.Pow(fourthSegment, 2);

            if (firstExpression!=secondExpression)
            {
                throw new ArgumentException("The sides or angles of quadrilateral are invalid");
            }
            return true;
        }

        public override double CalculateArea()
        {
            var firstTriangleArea = 0.5 * FirstSegment * SecondSegment * Math.Sin(FirstAngle);
            var secondTriangleArea = 0.5 * ThirdSegment * FourthSegment * Math.Sin(SecondAngle);
            var area = firstTriangleArea + secondTriangleArea;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = FirstSegment + SecondSegment + ThirdSegment + FourthSegment;
            return perimeter;
        }
    }
}
