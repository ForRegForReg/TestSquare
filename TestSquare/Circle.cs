using System;
namespace TestSquare
{
    public class Circle : ISquare
    {
        private double _Radius;
        public double Radius
        {           
            set
            {
                if (value > 0)
                    _Radius = value;
                else
                    throw new Exception("Некорректное значение радиуса.");
            }
            get
            {
                return _Radius;
            }
        }

        public Circle (double r)
        {
            Radius = r;
        }

        public double CalculateSquare()
        {
            return Radius * Radius * ConstInfo.Pi;
        }
    }
}
