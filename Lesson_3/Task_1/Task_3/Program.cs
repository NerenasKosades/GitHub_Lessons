using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово или фразу ");
            string word = Console.ReadLine();

            int n = word.Length;
           

            for(int i = n - 1; i < n && i >= 0; i--)
            {
                Console.Write(word[i]);
            }
                
        }    
    }
}
