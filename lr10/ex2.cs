//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lr10
//{
//    public class Price
//    {
//        private string name;
//        private string nameShop;
//        private float price;

//        public Price()
//        {
//            this.name = string.Empty;
//            this.nameShop = string.Empty;
//            this.price = 0f;
//        }

//        public void Set(string name, string shopName, float Price)
//        {
//            this.name = name;
//            this.nameShop = shopName;
//            this.price = Price;
//        }

//        public void Get()
//        {
//            Console.WriteLine($"Название товара: {this.name}\n\r" +
//                $"Название магазина: {this.nameShop}\n\r" +
//                $"Цена товара: {this.price}\n\r" +
//                $"--------------------------------");
//        }

//        public void FindProduct(string name)
//        {
//            if (name == this.name)
//            {
//                Console.WriteLine("Возможная стоимость искомого товара: " + this.price);
//            }
//        }
//    }
//    internal class ex2
//    {
//        static void Main(string[] args)
//        {
//            Price[] Prices = new Price[10];
//            string findName = Console.ReadLine();
//            for (int i = 0; i < Prices.Length; i++)
//            {
//                Prices[i] = new Price();
//                Prices[i].Set("Товар" + (i + 1), "Магазин" + (i + 1), (i + 1) * 13f);
//                Prices[i].FindProduct(findName);
//            }
//        }
//    }
//}
