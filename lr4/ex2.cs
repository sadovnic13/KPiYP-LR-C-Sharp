//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lr4
//{
//    internal class ex2
//    {
//        public static int FibDigit(int first, int second, ref int n)
//        {
//            if (n <= 2)
//            {
//                return second;
//            }

//            int buf = second;
//            second += first;
//            first = buf;
//            n--;

//            return FibDigit(first, second, ref n);
//        }


//        static void Main(string[] args)
//        {

//            int first = 0;
//            int second = 1;

//            Console.WriteLine("Введите порядковый номер элемента: ");
//            int n = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine(FibDigit(first, second, ref n));
//        }
//    }
//}
