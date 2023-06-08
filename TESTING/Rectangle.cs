using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTING
{
    public class Rectangle
    {
        private double p;
        public double a { get; }
        public double b { get; }
        public double c { get; }
        public Rectangle(double a, double b, double c)
        {
            if (a < 1e-7) throw new ArgumentException("Count Eror", nameof(a));
            if (b < 1e-7) throw new ArgumentException("Count Eror", nameof(b));
            if (c < 1e-7) throw new ArgumentException("Count Eror", nameof(c));
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double CalcSquare()
        {
            try
            {
                p = (a + b + c) / 2;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("parameters is not valid", nameof(a));
                throw new ArgumentException("parameters is not valid", nameof(b));
                throw new ArgumentException("parameters is not valid", nameof(c));
            }
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
