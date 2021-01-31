using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            string[,] numBook = new string[5, 2];
            string pref = "+7";
            Random random = new Random();

            numBook[0, 0] = "Вася";
            numBook[1, 0] = "Петя";
            numBook[2, 0] = "Коля";
            numBook[3, 0] = "Таня";
            numBook[4, 0] = "Катя";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    numBook[i, 1] = numBook[i, 1] + Convert.ToString(random.Next(9));
                }
                numBook[i, 1] = pref + numBook[i, 1];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($" {numBook[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
