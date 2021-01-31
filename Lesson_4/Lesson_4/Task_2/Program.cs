using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько чисел, разделенных между собой пробелом");
            string num = Console.ReadLine();
            int res = 0;

            string[] words = num.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                res += Convert.ToInt32(words[i]);
            }

            Console.WriteLine($"Сумма: {res}");
        }
    }
}
