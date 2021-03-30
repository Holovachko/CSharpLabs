using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x= ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[x+n];
            for (int i = 0; x < x+n; i++) {
                 a[i]= i;
            }
            int sum = 0;
            foreach (int element in a) {
                sum += element;
            }
            Console.WriteLine(sum / a.Length);

        }
    }
}
