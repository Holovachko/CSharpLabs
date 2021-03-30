using System;

namespace ex3
{
    class Program
    {
        static int Factorial(int number) {
            int i, fact;
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            return number;

        }
        static void Main(string[] args)
        {

            Console.Write("m = ");
            double m = Convert.ToDouble(Console.ReadLine()) ;
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Epsilon = ");
            double epsilon = Convert.ToDouble(Console.ReadLine());
            double numerator = m;
            double res = m * x;
            int i = 2;
            do
            {
                numerator += numerator * (m - (i - 1));
                res += (((numerator * (m - (i - 1))) / Factorial(i))) * Math.Pow(x, i);
                i += 1;
            }
            while (Math.Abs(numerator) > epsilon);
            Console.WriteLine(res);

        }
    }
}
