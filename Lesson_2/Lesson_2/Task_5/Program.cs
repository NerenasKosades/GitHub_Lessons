using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMon, temp;

            Console.Write("Введите номер месяца ");
            numMon = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите температуру ");
            temp = Convert.ToInt32(Console.ReadLine());

            if ((numMon == 12 || numMon == 1 || numMon == 2) && temp > 0)
                Console.WriteLine("Дождливая зима");            
        }
    }
}
