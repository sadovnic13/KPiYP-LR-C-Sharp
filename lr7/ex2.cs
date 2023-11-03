//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace lr7
//{
//    internal class ex2
//    {
//        public static void Main(string[] args)
//        {
//            StringBuilder str = new StringBuilder("Hello      ## flg   .");
//            Console.WriteLine(str);

//            str = str.Replace("#", string.Empty);
//            str = new StringBuilder(Regex.Replace(str.ToString(), @"\s{2,}", " ").Trim());

//            Console.WriteLine(str);
//        }
//    }
//}
