using System;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку ");
            string str1 = Console.ReadLine();

            string fileName = "Task_1_text.txt";

            File.WriteAllText(fileName, str1);
        }
    }
}
