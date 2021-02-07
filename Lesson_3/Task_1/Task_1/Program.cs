using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание массива");
            int[,] array = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(5);
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вывод элементов массива по диагонали слева направо, сверху вниз");
            for (int k = 0; k < 5; k++)
            {
                for (int l = 0; l < 5; l++)
                {
                    if (k == l)
                    {
                        Console.Write($" {array[k, l]}");
                    }
                }
            }
        }
    }
}
