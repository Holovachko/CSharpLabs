using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerator = 1.0 , denumirator = 2.0 , number = 0.1;

            double result = 1;
            for (int i = 0; i < 9; i++ , numerator++, denumirator++) {
                result *= numerator / denumirator + Math.Cos(number) ;
                number += 0.1;
            
            }
            Console.WriteLine(result);
        }
    }
}
