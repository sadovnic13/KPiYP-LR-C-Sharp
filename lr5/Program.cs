using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Price
    {
        private string name;
        private string nameShop;
        private float price;

        public Price()
        {
            this.name = string.Empty;
            this.nameShop = string.Empty;
            this.price = 0f;
        }

        public void Set(string name, string shopName, float Price)
        {
            this.name = name;
            this.nameShop = shopName;
            this.price = Price;
        }

        public void Get()
        {
            Console.WriteLine($"Название товара: {this.name}\n\r" +
                $"Название магазина: {this.nameShop}\n\r" +
                $"Цена товара: {this.price}\n\r" +
                $"--------------------------------");
        }

        public void FindProduct(string name)
        {
            if (name == this.name)
            {
                Console.WriteLine("Возможная стоимость искомого товара: " + this.price);
            }
        }
    }

    public class Price1 : Price
    {
        private int remainingUnits;

        // Конструктор без параметров
        public Price1() : base()
        {
            Console.WriteLine("Вызван конструктор без параметров");
            this.remainingUnits = 0;
        }

        // Конструктор с параметрами
        public Price1(string name, string shopName, float price, int remainingUnits) : base()
        {
            Console.WriteLine("Вызван конструктор с параметрами");
            Set(name, shopName, price);
            this.remainingUnits = remainingUnits;
        }

        // Метод для ввода значений полей класса с клавиатуры
        public void InputFromKeyboard()
        {
            Console.WriteLine("Введите название товара:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите название магазина:");
            string shopName = Console.ReadLine();

            Console.WriteLine("Введите цену товара:");
            float price = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество оставшихся единиц товара:");
            int remainingUnits = int.Parse(Console.ReadLine());

            Set(name, shopName, price);
            this.remainingUnits = remainingUnits;
        }

        // Метод для вывода значений полей класса на экран
        public new void Get()
        {
            base.Get();
            Console.WriteLine($"Количество оставшихся единиц товара: {this.remainingUnits}\n\r" +
                $"--------------------------------");
        }
    }

    internal class Program
    {
        // Создаем массив объектов Price1
        static void Main(string[] args)
        {
            // Создаем массив объектов Price1
            Price1[] prices = new Price1[5];

            // Инициализируем каждый объект в массиве
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = new Price1();
                prices[i].Set("Товар" + (i + 1), "Магазин" + (i + 1), (i + 1) * 13f);
                prices[i].Get();
            }
        }
    }
}
