using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть третє число: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть початок інтервалу: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть початок кінець: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x <= a && a <= y && x <= b && b <= y && x <= c && c <= y) {
                double sum = a + b + c;
                Console.WriteLine(sum);

            }
            else if (x <= a && a <= y && x <= b && b <= y)
            {
                double sum = a + b;
                Console.WriteLine(sum);
            }
            else if (x <= a && a <= y && x <= c && c <= y)
            {
                double sum = a + c;
                Console.WriteLine(sum);
            }
            else if (x <= b && b <= y && x <= c && c <= y)
            {
                double sum = b + c;
            }
            else
                Console.WriteLine("Не входять до проміжку");

        }
    }
}
