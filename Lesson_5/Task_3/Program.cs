using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 255");
            byte[] num = new byte[1];
            num[0] = Convert.ToByte(Console.ReadLine());

            string fileName = "Task_3_bin.bin";

            File.WriteAllBytes(fileName, num);

        }
    }
}
