using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число ");
            int num = Convert.ToInt32(Console.ReadLine());     
            
            if (num % 2 == 0)
                Console.WriteLine("Число четное");
            else
                Console.WriteLine("Число нечетное");
        }
    }
}
