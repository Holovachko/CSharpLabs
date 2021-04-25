using System;
using System.Collections.Generic;
using System.Text;

namespace lab15
{
    class TrianglePiramid : Interface1
    {
        double a, b, c;

        public TrianglePiramid(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        double Interface1.foundationsArea()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        double Interface1.surfaceArea(double L)
        {
            double perimetr = a + b + c;
            double p = (a + b + c) / 2.0;
            return ((1/2.0) * perimetr * L) + Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        double Interface1.piramidVolume(double h)
        {
            return (h*Math.Pow(a, 2))/(4*Math.Sqrt(3));
            
        }

    }
}
