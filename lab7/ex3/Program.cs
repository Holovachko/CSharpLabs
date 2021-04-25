using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[2, 2];
            double det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }
    }
}
