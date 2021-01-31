using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int numFib = Convert.ToInt32(Console.ReadLine());
            int res = Fibonachi(numFib);
            Console.WriteLine($"Число Фибоначчи:{res}");
        }
        static int Fibonachi(int numF)
        {
            if (numF == 0 || numF == 1)
                return numF;
            else
                return Fibonachi(numF - 1) + Fibonachi(numF - 2);
        }
    }
}
