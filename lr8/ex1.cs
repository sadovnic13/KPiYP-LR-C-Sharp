//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace lr8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = "Это исходна строка больше десяти слова. В ней мы выполним поиск и замену слова 'слова'";
//            string pattern = "слова";
//            string replacment = "фраза";

//            if (Regex.IsMatch(input, pattern))
//            {
//                Console.WriteLine("Слово или подстрока '{0}' найдена в исходной строке.", pattern);
//            }
//            else
//            {
//                Console.WriteLine("Слово или подстрока '{0}' не найдена в исходной строке.", pattern);
//            }

//            int count = Regex.Matches(input, pattern).Count;
//            Console.WriteLine($"Всего подстрок найдено {count}");

//            Console.WriteLine(Regex.Replace(input, pattern, replacment));
//        }
//    }
//}
