using System;

namespace TestSquare
{
    public class Triangle : ISquare
    {

        private double _A;
        private double _B; 
        private double _C;

        public double A {
            get
            {
                return _A;
            }
            set
            {
                if (value > 0)
                    _A = value;
                else
                    throw new Exception("Некорректное значение стороны.");
            }
        }
        public double B {
            get
            {
                return _B;
            }
            set
            {
                if (value > 0)
                    _B = value;
                else
                    throw new Exception("Некорректное значение стороны.");
            }
        }
        public double C {
            get
            {
                return _C;
            }
            set
            {
                if (value > 0)                
                    _C = value;
                else
                    throw new Exception("Некорректное значение стороны.");
            }
        }

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
