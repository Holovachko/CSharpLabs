using System;

namespace Ex3
{
    class Program
    {

        static double func(int i) {
            int[] array = new int[100];
            array[0] = 2;
            array[1] = 3;
            array[2] = 3;

            return array[i] = 7 * array[i - 1] - array[i - 2] * array[i - 3];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(func(3));
        }
    }
}
