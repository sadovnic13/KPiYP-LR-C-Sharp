using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr7
{
    internal class ex4
    {
        public static void Main(string[] args)
        {
            var str1 = "ft";
            string str2 = "x a d c x y xw";

            foreach (char arg in str1) 
            {
                if (str2.Count(x => x == arg) > 0)
                {
                    Console.WriteLine("Элемент найден");
                    return;
                }
            }
            Console.WriteLine("Элемент не найден");
        }
    }
}
