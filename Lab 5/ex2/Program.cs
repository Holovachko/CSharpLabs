using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            double res = (x + y) / 2.0;
            double answer = (x * 10 + y) + 2;
            Console.WriteLine(answer);
        }
    }
}
