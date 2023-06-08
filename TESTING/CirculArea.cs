namespace TESTING
{
    public class Circul
    {
        public double Radius { get; }
        public Circul(double radius)
        {
            if(radius < 1e-7)
            {
                throw new ArgumentException("Radius count Error", nameof(radius));
            }
            Radius = radius;
        }
        public double CalcSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}