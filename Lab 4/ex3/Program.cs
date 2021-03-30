using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ax = ");
            double Ax =Convert.ToDouble(Console.ReadLine()) ;
            Console.Write("Ay = ");
            double Ay = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bx = ");
            double Bx = Convert.ToDouble(Console.ReadLine());
            Console.Write("By = ");
            double By = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cx = ");
            double Cx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cy = ");
            double Cy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dx = ");
            double Dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dy = ");
            double Dy = Convert.ToDouble(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow((Bx - Ax),2)+ Math.Pow((By - Ay),2));
            double BC = Math.Sqrt(Math.Pow((Cx - Bx), 2) + Math.Pow((Cy - By), 2));
            double AD = Math.Sqrt(Math.Pow((Dx - Ax), 2) + Math.Pow((Dy - Ay), 2));
            double CD = Math.Sqrt(Math.Pow((Dx - Cx), 2) + Math.Pow((Dy - Cy), 2));

            if (AB + CD == BC + AD) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
    }
}
