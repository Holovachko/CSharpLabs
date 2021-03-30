using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double z;
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            double n = Convert.ToDouble(Console.ReadLine());
            if (n == 10)
                z = Math.Sin(Math.Pow(x, n));
            else if (n == 22)
                z = Math.Pow(x, n);
            else if (n == 3)
                z = Math.Pow(n, x);
            else
                z = 1;
            Console.WriteLine(z);
        }
    }
}
