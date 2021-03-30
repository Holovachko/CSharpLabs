using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("i = ");
            int i = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[i];
            a[0] = b;
            a[1] = b;

            for(int n = 2; n < i; n++)
            {
                a[n] = a[n - 2] + (a[n-1])/(Math.Pow(2,n-1));
            }
            double sum = 0;
            for(int n = 1; n < i; n += 2)
            {
                sum += a[n];
            }
            Console.WriteLine(sum);
        }
    }
}
