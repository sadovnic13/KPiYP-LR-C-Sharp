using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lr6
{
    internal class ex3
    {
        public static int FindNumber(ref int[] array, int alfa)
        {
            int summ = 0;
            foreach (var item in array)
            {
                if (item > alfa)
                {
                    summ++;
                }
            }

            return summ;
        }

        public static void Main(string[] args)
        {
            int alfa = 2;

            int[] a = new int[15];
            int[] b = new int[15];
            Random rnd = new Random();

            Console.WriteLine("Массив 1:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-2, 8);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine("\nМассив 2:");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(-2, 8);
                Console.Write(b[i] + " ");
            }

            int aCol = FindNumber(ref a, alfa);
            int bCol = FindNumber(ref b, alfa);

            Console.WriteLine("\n\rКоличество элементов больше: \n\r  " + aCol + "   " +  bCol);
        }

    }
}
