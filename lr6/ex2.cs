//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lr6
//{
//    internal class ex2
//    {
//        public static void Main(string[] args)
//        {
//            Random rnd = new Random();
//            int[,] array = new int[5, 3];

//            for (int i = 0; i < 3; i++)
//            {
//                bool isPlus = true;
//                int summ = 0;
//                for (int j = 0; j < 5; j++)
//                {
//                    array[j, i] = rnd.Next(-1, 5);
//                    summ += array[j, i];
//                    if (array[j, i] < 0) 
//                    {
//                        isPlus = false;
//                    }

//                    Console.Write("{0,3}",array[j, i]);
//                }
//                if (isPlus)
//                {
//                    Console.Write("{0,3}", summ);
//                }

//                Console.WriteLine();
//            }
//        }

//    }
//}
