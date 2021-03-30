using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість елементів масива: ");
            int i = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[i];
            double[] b = new double[i];
            double[] sum = new double[i];
            double[] minus = new double[i];
            double product = 0;
            for (int n = 0; n < i; n++)
            {
                sum[n] = a[n] + b[n];
            }
            for (int n = 0; n < i; n++)
            {
                minus[n] = a[n] - b[n];
            }
            for (int n = 0; n < i; n++)
            {
                product += a[n] * b[n];
            }
            double s = 2 * product;
            Console.WriteLine(s);
        }
    }
}
