using System;
using System.Collections.Generic;
using System.Text;

namespace lab15
{
    class QuadPiramid : Interface1
    {
        double a;
        public QuadPiramid(double a)
        {
            this.a = a;
        }

        double Interface1.foundationsArea()
        {
            return a * a;
        }
        double Interface1.piramidVolume(double h)
        {
            return (1 / 3.0) * (a * a) * h;
        }
        double Interface1.surfaceArea(double L)
        {
            return ((1 / 2.0) * 4 * a * L) + a * a;
        }
    }
}
