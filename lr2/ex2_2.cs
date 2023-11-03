using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    internal class ex2_2
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double R = rand.Next(1, 11);
            double h = rand.Next(1, 11);

            double V = Math.Round((1.0 / 3.0) * Math.PI * Math.Pow(R, 2) * h , 2);

            double S = Math.Round(Math.PI * R * (R + Math.Sqrt(Math.Pow(R, 2) + Math.Pow(h, 2))), 2);

            Console.WriteLine($"R = {R}, h = {h}, V = {V}, S = {S}");
        }
    }
}
