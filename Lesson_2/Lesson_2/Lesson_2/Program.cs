using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            double midTemp, minTemp, maxTemp;

            Console.Write("Введите минимальную температуру за сутки ");
            minTemp = Convert.ToInt32(Console.ReadLine());            
            Console.Write("Введите максимальную температуру за сутки ");
            maxTemp = Convert.ToInt32(Console.ReadLine());

            midTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine($"Среднесуточная температура составляет {midTemp}");
        }
    }
}
