using FigureCalculator;
using NUnit.Framework;

namespace FigureCalculatorTests
{
    public class CommonTests
    {
        public static IEnumerable<TestCaseData> FiguresWithExpectedAreas()
        {
            yield return new TestCaseData(new Triangle(1, 2, 3), 0);
            yield return new TestCaseData(new Triangle(3, 4, 5), 6);
            yield return new TestCaseData(new Triangle(12, 15, 18), 89.2941);
            yield return new TestCaseData(new Triangle(15, 19, 26), 140.7125);
            yield return new TestCaseData(new Circle(0), 0);
            yield return new TestCaseData(new Circle(3), Math.PI * 9);
            yield return new TestCaseData(new Circle(5), Math.PI * 25);
            yield return new TestCaseData(new Circle(250), Math.PI * 250 * 250);
        }

        [TestCaseSource(nameof(FiguresWithExpectedAreas))]
        public void IsAreaCorrectTests(IFigure figure, double expectedArea)
        {
            Assert.AreEqual(expectedArea, figure.GetArea(), 0.0001, "Calculated area was different then expected");
        }
    }
}