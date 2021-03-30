using System;
using System.Collections.Generic;
using System.Text;

namespace ex3
{
    class GeomProgression
    {
        double[] progression;
        double q;

        public double Q { get; set; }
        public double this[int i]
        {
            get{
                if (i >= 0 && i < progression.Length)
                    return progression[i];
                else
                    return 0;
            }
            set
            {
                if (i >= 0 && i < progression.Length)
                    progression[i] = value;
            }
        }

        public void setProgretion(params double[] x)
        {
            progression = new double[x.Length];
            x.CopyTo(progression,0);
        }
        public void getProgretion()
        {
            for(int i = 0; i < progression.Length; i++)
            {
                Console.WriteLine(progression[i]);
            }
        }
        public double sumProgretion(int n)
        {
            return (progression[0]*(Math.Pow(q,n)-1)) / (q - 1.0);
        }
    }
}
