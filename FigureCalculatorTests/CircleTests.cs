using FigureCalculator;
using NUnit.Framework;

namespace FigureCalculatorTests
{
    public class CircleTests
    {
        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1), "Expected exception was not thrown");
        }
    }
}
