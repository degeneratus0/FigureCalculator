using FigureCalculator;
using NUnit.Framework;

namespace FigureCalculatorTests
{
    public class TriangleTests
    {
        [Test]
        public void TriangleConstructorTest()
        {
            double a = 3, b = 4, c = 5;
            Triangle triangle = new Triangle(a, b, c);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(a, triangle.Side1, "Side 1 value was not as expected");
                Assert.AreEqual(b, triangle.Side2, "Side 2 value was not as expected");
                Assert.AreEqual(c, triangle.Side3, "Side 3 value was not as expected");
            });
        }

        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 0, 0)]
        public void IncorrectTriangleSidesTests(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c), "Expected exception was not thrown");
        }

        [TestCase(1, 1, 5)]
        [TestCase(1, 15, 5)]
        [TestCase(100, 5, 15)]
        public void NonExistentTriangleTests(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c), "Expected exception was not thrown");
        }

        [Test]
        public void TrianglePerimeterTest()
        {
            double a = 3, b = 4, c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(a + b + c, triangle.Perimeter, "Perimeter wasn't calculated correctly");
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(3, 4, 6, false)]
        public void IsRightTriangleTest(double a, double b, double c, bool isRight)
        {
            Assert.AreEqual(isRight, new Triangle(a, b, c).IsRightTriangle, "Triangle rightness wasn't determined correctly");
        }
    }
}
