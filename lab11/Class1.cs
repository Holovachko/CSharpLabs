using System;
using System.Collections.Generic;
using System.Text;

namespace lab11
{
    class TGeomProgression
    {
        double firstEl;
        double q;

        public TGeomProgression()
        {
            firstEl = 1;
            q = 1;
        }

        public TGeomProgression(double firstEl, double d)
        {
            this.firstEl = firstEl;
            this.q = d;
        }
        public TGeomProgression(TGeomProgression r)
        {
            this.firstEl = r.firstEl;
            this.q = r.q;
        }
        public double FirstEl
        {
            get { return firstEl; }
            set { firstEl = value; }
        }
        public double Q
        {
            get { return q; }
            set { q = value; }
        }

        public double nElProgretion(int i)
        {
            return firstEl * Math.Pow(q, i-1);
        }
        public double sumOfEl(int i)
        {
            return (firstEl *(Math.Pow(q,i)-1)/q-1.0);
        }
        public static TGeomProgression operator +(TGeomProgression v1, TGeomProgression v2)
        {
            return new TGeomProgression(v1.firstEl + v2.firstEl, v1.q + v2.q);
        }
        public static TGeomProgression operator -(TGeomProgression v1, TGeomProgression v2)
        {
            return new TGeomProgression(v1.firstEl - v2.firstEl, v1.q - v2.q);
        }

    }
}

