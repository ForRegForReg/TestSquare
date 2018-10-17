using System;

namespace TestSquare
{
    public class Triangle : ISquare
    {
        public double A {get; set;}
        public double B { get; set; }
        public double C { get; set; }

        public bool IsRectangular
        {
            get
            {
                return ((A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == A * A + B * B));
            }
        }

        public double p
        {
            get
            {
                return (A + B + C) / 2;
            }
        }

        public Triangle (double a, double b, double c )
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalculateSquare()
        {
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
