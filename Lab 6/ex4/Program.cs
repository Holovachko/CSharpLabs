using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Довжина масива = ");
            int i = Convert.ToInt32(Console.ReadLine());
            double[] b = new double[i];
            for (int n = 0; n < i; n++) {
                Console.Write("Запишіть елемент b[{0}] = ",n);
                b[n] = Convert.ToDouble(Console.ReadLine());

            }
            Array.Sort(b);
            for(int n = 0; n < i; n++)
            {
                Console.WriteLine(b[n]);
            }

        }
    }
}
