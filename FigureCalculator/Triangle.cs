namespace FigureCalculator
{
    public class Triangle : Figure
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public double Perimeter { get; }
        public override double Area { get; }
        public bool IsRightTriangle { get; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Every side must be greater than 0");
            }

            if (side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < side1)
            {
                throw new ArgumentException("Every side of a triangle must be less then sum of two other sides");
            }

            (Side1, Side2, Side3) = (side1, side2, side3);
            Perimeter = Side1 + Side2 + Side3;
            Area = GetArea();
            IsRightTriangle = IsRight();
        }

        private bool IsRight()
        {
            double squareSide1 = Math.Pow(Side1, 2d);
            double squareSide2 = Math.Pow(Side2, 2d);
            double squareSide3 = Math.Pow(Side3, 2d);
            return squareSide1 + squareSide2 == squareSide3 || 
                squareSide1 + squareSide3 == squareSide2 || 
                squareSide2 + squareSide3 == squareSide1;
        }

        private double GetArea()
        {
            double halfPerimeter = Perimeter / 2d;
            return Math.Sqrt(
                halfPerimeter *
                (halfPerimeter - Side1) *
                (halfPerimeter - Side2) *
                (halfPerimeter - Side3)
                );
        }
    }
}
