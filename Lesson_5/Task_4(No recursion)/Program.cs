using System;
using System.IO;

namespace Task_4_No_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string directName = @"D:\ExampleDir";

            if (Directory.Exists(directName))
            {                
                string[] dirs = Directory.GetDirectories(directName);
                string resFile = "Res.txt";
                File.WriteAllText(resFile, "ФАЙЛЫ И ПОДКАТАЛОГИ БЕЗ РЕКУРСИИ");
                File.AppendAllText(resFile, Environment.NewLine);
                File.AppendAllText(resFile, Environment.NewLine);
                File.AppendAllText(resFile, "Подкаталоги: ");
                File.AppendAllText(resFile, Environment.NewLine);
                foreach (string s in dirs)
                {                        
                    File.AppendAllText(resFile, s);
                    File.AppendAllText(resFile, Environment.NewLine);
                }
                File.AppendAllText(resFile, Environment.NewLine);               
                string[] files = Directory.GetFiles(directName);
                File.AppendAllText(resFile, "Файлы: ");
                File.AppendAllText(resFile, Environment.NewLine);
                foreach (string s in files)
                {                                
                    File.AppendAllText(resFile, s);
                    File.AppendAllText(resFile, Environment.NewLine);
                }

            }
        }

    }
}
