using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class nAngle
    {
        int angles;
        double[] vertex;

        public int Angles {
            get { return angles;}
            set { angles = value;}
        }
        public double[] Vertex
        {
            get { return vertex; }
            set { vertex = value; }
        }
        public nAngle(int angles,params double[] vertex ) {
            this.angles = angles;
            this.vertex = vertex;
        }

        public double P() {
            int sum = 0;
            foreach (int value in vertex)
            {
                sum += value;
            }
            return sum;

        }
    }
}
