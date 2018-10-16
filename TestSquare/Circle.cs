namespace TestSquare
{
    public class Circle : ISquare
    {
        public double Radius { get; set; }

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
