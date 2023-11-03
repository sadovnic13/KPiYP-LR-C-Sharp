using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4
{
    internal class ex1
    {
        public static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        public static double Y(double x)
        {
            return Math.Pow(2.71, Math.Cos(x)) * Math.Cos(Math.Sin(x));
        }

        public static double S(double x, double n)
        {
            double s = 0;
            for (int k = 1; k < n; k++)
            {
                s += Math.Cos(k * x) / Factorial(k);
            }
            return s;
        }

        public static void Main()
        {
            Console.WriteLine("Введите a,b,h,n:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("x\t\tY(x)\t\tS(x)+|Y(x)-S(x)|");
            for (double x = a; x <= b; x += h)
            {
                double y = Y(x);
                double s = S(x, n);

                Console.WriteLine($"{x,-5} {y,-5}\t{Math.Abs(y - s),5}");
            }
        }



    }
}
