namespace FigureCalculator
{
    public class Circle : Figure
    {
        public double Radius { get; }
        public override double Area { get; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must not be negative");
            }
            Radius = radius;
            Area = GetArea();
        }

        private double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
