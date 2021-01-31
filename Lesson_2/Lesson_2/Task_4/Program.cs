using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, dis = 20, price = 6000;
            sum = price - price / 100 * 20;
            string nameShop = "Веселые побрякушки", cashier = "Дуделкин И.В.";
            Console.WriteLine(" _______________________________");
            Console.WriteLine("|         КАССОВЫЙ ЧЕК          |");
            Console.WriteLine($"|       {nameShop}      |");            
            Console.WriteLine("|===============================|");
            Console.WriteLine($"|Стоимость                  {price}|");
            Console.WriteLine($"|Скидка                      {dis}%|");
            Console.WriteLine($"|К оплате                   {sum}|");
            Console.WriteLine($"|Кассир            {cashier}|");
            Console.WriteLine("|===============================|");
            Console.WriteLine($"|Дата, время: {DateTime.Now}|");
            Console.WriteLine("|_______________________________|");
        }
    }
}
