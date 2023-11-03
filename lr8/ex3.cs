using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lr8
{
    internal class ex3
    {
        public static void Main(string[] args)
        {
            string input = "Государственный экзамен состоится 25.06.2020";

            Regex regex = new Regex(@"\d{2}.\d{2}.\d{4}");
            Match match = regex.Match(input);
            if (match.Success)
            {
                Console.WriteLine("Дата экзамена: " + match.Value);
                return;
            }
            Console.WriteLine("Информация не найдена");
        }
    }
}
