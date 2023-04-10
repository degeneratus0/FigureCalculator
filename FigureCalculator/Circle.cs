namespace FigureCalculator
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must not be negative");
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
