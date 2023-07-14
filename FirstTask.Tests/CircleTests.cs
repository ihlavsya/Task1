using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        [TestCase(3, 18.85)]
        [TestCase(2, 12.57)]
        public void CalculatePerimeterTest(double radius, double expected)
        {
            var circle = new Circle(radius);

            var perimeter = circle.CalculatePerimeter();

            Assert.That(perimeter, Is.EqualTo(expected).Within(0.01));
        }

        [Test]
        [TestCase(3, 28.27)]
        [TestCase(2, 12.57)]
        public void CalculateAreaTest(double radius, double expected)
        {
            var circle = new Circle(radius);

            var area = circle.CalculateArea();

            Assert.That(area, Is.EqualTo(expected).Within(0.01));
        }
    }
}
