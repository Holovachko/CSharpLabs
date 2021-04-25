using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int height;
            int sum = 0; 
            Console.Write("Введите довжину матриці: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Введите висоту матриці: ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("\nЗаповніть матрицю\n");
            int[,] ara = new int[length, height];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("Введите число: ");
                    ara[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("{0} ", ara[i, j]);
                    if (i%2 == 0 && j%2 == 0) {
                        sum += ara[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nСумма парних чисел матриці = {0}", sum);
        }
    }
}
