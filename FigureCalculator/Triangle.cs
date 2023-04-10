namespace FigureCalculator
{
    public class Triangle : IFigure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public double Perimeter { 
            get
            {
                return Side1 + Side2 + Side3;
            } 
        }

        public bool IsRightTriangle
        {
            get
            {
                return IsRight();
            }
        }

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

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
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

        public double GetArea()
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
