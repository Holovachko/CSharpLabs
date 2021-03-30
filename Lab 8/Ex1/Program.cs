using System;

namespace Ex1
{
   
    class Program
    {
        static int Funct(double x)
        {
            if (x < 23) return 0;
            else if (x == 23) return 1;
            else return -1;

        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = Funct(4) + 2 * Funct(a) - Funct(b);
            Console.WriteLine(sum);


        }
        

    }


}
