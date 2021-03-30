using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class TGeomProgressionM : TGeomProgression
    {
        public TGeomProgressionM(double firstEl, double q) : base(firstEl, q)
        { }
        public bool isProgretion(params double[] x)
        {
            int i = x.Length;
            if (x[Convert.ToInt32(Math.Pow(i,2))] == x[i+1] * x[i-1])
                return true;
            else
                return false;
        }

        public bool isElement(double el)
        {

            for (int i = 1; i < el; i++)
            {
                if (FirstEl * Math.Pow(Q , i-1) == el)
                    return true;
            }
            return false;
        }
    }
}
