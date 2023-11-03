using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    internal class ex2
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            float a = -2f;
            float b = 0.8f;
            float h = 0.2f;
            int i = 0;
            Console.WriteLine("№\tx\tf(x)");
            for (; a < b; a += h)
            {
                double f = (a * Math.Cos(pi / 4) - Math.Pow(a, 3)) / (1 - 2 * a * Math.Cos(pi / 4) + Math.Pow(a, 2));
                Console.WriteLine("{0}\t{1:f2}\t{2:f2}", ++i, a, f);
            }

        }
    }
}
