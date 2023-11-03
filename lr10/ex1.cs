//namespace lr10
//{
//    internal class ex1
//    {
//        public class DatabaseHandler
//        {
//            public DatabaseHandler()
//            {
//                // Конструктор базового класса по умолчанию
//            }

//            public void CommonFunction()
//            {
//                // Общая функциональность для баз дынных
//            }
//        }

//        // Класс для первой БД
//        public class Type1DatabaseHandler : DatabaseHandler
//        {
//            public Type1DatabaseHandler() : base()
//            {
//                // Конструктор производного класса, независимый от базового класса
//            }

//            public void SpecificFunctionForType1()
//            {
//                // Специфическая функциональность для первой БД
//            }
//        }

//        // Производный класс для второй БД
//        public class Type2DatabaseHandler : DatabaseHandler
//        {
//            public Type2DatabaseHandler() : base()
//            {
//                // Конструктор производного класса, независимый от базового класса
//            }

//            public void SpecificFunctionForType2()
//            {
//                // Специфическая функциональность для второй БД
//            }
//        }
//        static void Main(string[] args)
//        {
//            Type1DatabaseHandler firstDB = new Type1DatabaseHandler();
//            Type2DatabaseHandler secondDB = new Type2DatabaseHandler();
//        }
//    }
//}