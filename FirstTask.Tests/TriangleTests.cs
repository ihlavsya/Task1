namespace FirstTask.Tests
{
    [TestFixture]
    public class TriangleTests
    { 

        [Test]
        [TestCase(3, 4, 5, 12)]
        [TestCase(2, 2, 1, 5)]
        public void CalculatePerimeterTest(double firstSegment, double secondSegment, double thirdSegment, double expected)
        {
            var triangle = new Triangle(firstSegment, secondSegment, thirdSegment);

            var perimeter = triangle.CalculatePerimeter();

            Assert.That(perimeter, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(3, 4, 5, 6)]
        [TestCase(2, 2, 1, 0.97)]
        public void CalculateAreaTest(double firstSegment, double secondSegment, double thirdSegment, double expected)
        {
            var triangle = new Triangle(firstSegment, secondSegment, thirdSegment);

            var area = triangle.CalculateArea();

            Assert.That(area, Is.EqualTo(expected).Within(0.01));
        }
    }
}