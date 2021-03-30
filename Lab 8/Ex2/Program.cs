using System;

namespace Ex2
{
    class Program
    {
        static int fibonacci(int x) {
            
            if (x == 1) return 0;
            else if (x == 2) return 1;
            else return fibonacci(x - 1) + fibonacci(x - 2);


        }
        static void Main(string[] args)
        {
            int sum = fibonacci(3) + fibonacci(8);
            Console.WriteLine(sum);
        }
    }
}
