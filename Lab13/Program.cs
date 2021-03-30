using System;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            TVector2D q = new TVector2D();
            q.X = 14;
            Console.WriteLine(q.X);
            q.setVect(1, 25, 1, 6, 3);
            Console.WriteLine(q.getLenght());
        }
    }
}
