using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Запишіть перше число: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Запишіть друге число: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double sum = d + c;
            double geometricMean = Math.Sqrt(d * c);
            double arithmeticMean = (d + c) / 2.0;
            Console.WriteLine("Сумма чисел ={0} , Середнє арифметичне ={1} , Середнє геометричне ={2} ." ,sum ,geometricMean,arithmeticMean);
        }
    }
}
