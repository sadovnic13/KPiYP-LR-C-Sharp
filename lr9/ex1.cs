//namespace lr9
//{
//    internal class ex1
//    {

//        public struct Student
//        {
//            public string fio;
//            public int born;
//            public int grupp;
//            public Dictionary<string, int> marks;
//            public double avg;
//        }

//        static void Main(string[] args)
//        {
//            Student[] students = new Student[]
//            {
//                new Student
//                {
//                    fio = "Нагорный Г.А.", born = 2006, grupp = 65, marks = new Dictionary<string, int>
//                    {
//                        { "Физика", 10 },
//                        { "Математика", 10 },
//                        { "Информатика", 8 },
//                        { "Химия", 9 }
//                    }, avg = 0
//                },
//                new Student
//                {
//                    fio = "Ломоносов А.М.", born = 2006, grupp = 65, marks = new Dictionary<string, int>
//                    {
//                        { "Физика", 2 },
//                        { "Математика", 6 },
//                        { "Информатика", 10 },
//                        { "Химия", 7 }
//                    }, avg = 0
//                },
//                new Student
//                {
//                    fio = "Иванов И.И", born = 2005, grupp = 45, marks = new Dictionary<string, int>
//                    {
//                        { "Физика", 7 },
//                        { "Математика", 7 },
//                        { "Информатика", 8 },
//                        { "Химия", 8 }
//                    }, avg = 0
//                }
//            };

//            for (int i = 0; i < students.Length; i++)
//            {
//                students[i].avg = students[i].marks.Values.Average();
//                Console.WriteLine($"Фамилия и инициалы: {students[i].fio}, Год рождения: {students[i].born}, Номер группы: {students[i].grupp}, Средний балл: {students[i].avg}");
//            }

//            Console.WriteLine();

//            bool isOne = false;
//            foreach (var item in students)
//            {
//                if (item.fio[0] == 'A' && (item.marks["математика"] == 9 || item.marks["математика"] == 10))
//                {
//                    isOne = true;
//                    Console.WriteLine($"Фамилия и инициалы: {item.fio}, Год рождения: {item.born}, Номер группы: {item.grupp}, Средний балл: {item.avg}");
//                }
//            }

//            if (!isOne)
//            {
//                Console.WriteLine("Таких стдентов нет");
//            }
//        }
//    }
//}
