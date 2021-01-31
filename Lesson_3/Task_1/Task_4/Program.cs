using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] field = new string [10, 10];

            // Заполнение массива символом О
            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 10; j++)
                {
                    field[i, j] = "O";                    
                }
            }

            // Попытки заполнить массив кораблями рандомно увенчались провалом - выползаю за пределы массива постоянно

            field[3, 4] = "X";
            field[4, 4] = "X";
            field[5, 4] = "X";
            field[6, 4] = "X";

            field[0, 0] = "X";
            field[0, 1] = "X";
            field[0, 2] = "X";

            field[6, 1] = "X";
            field[7, 1] = "X";
            field[8, 1] = "X";

            field[1, 6] = "X";
            field[2, 6] = "X";

            field[5, 8] = "X";
            field[5, 9] = "X";

            field[7, 7] = "X";
            field[8, 7] = "X";

            field[2, 1] = "X";

            field[8, 3] = "X";

            field[0, 8] = "X";

            field[8, 8] = "X";

            // Вывод массива на консоль                        
            for (int y = 0; y < 10; y++)
            {
                for (int z = 0; z < 10; z++)
                {
                    Console.Write(field[y, z]);
                }
                Console.WriteLine();
            }
           
            

        }
    }
}
