using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 3;
            double res = 0;
            int[] array = new int[100];
            array[0] = 0;
            array[1] = 9;
            array[2] = -9;
            array[3] = 10;

            do {
                int xi =Convert.ToInt32( Math.Sin(array[i-3]) + 2 * array[i-1] + 3 * array[i-2]);
                array[i + 1] = xi;
                i += 1;

            } while (i < n);
            Console.WriteLine(array[i]);
        }
    }
}
