using System;
using System.Diagnostics;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Process notePad = Process.Start("notepad");
            Process notePad2 = Process.Start("notepad");
            Console.WriteLine("Запущен процесс блокнота Id = " + notePad.Id);
            Console.WriteLine("Все экземпляры блокнота:");
            Process[] localByName = Process.GetProcessesByName("notepad");
            int i = localByName.Length;
            while (i > 0)
            {
                Console.WriteLine(localByName[i - 1].Id.ToString());
                i -= 1;
            }

            i = localByName.Length;
            while (i > 0)
            {
                Console.WriteLine("Введите Id для завершения процесса");
                string id = Console.ReadLine();
                if (string.IsNullOrEmpty(id))
                    break;

                try
                {
                    using (Process chosen = Process.GetProcessById(Int32.Parse(id)))
                    {
                        if (chosen.ProcessName == "notepad")
                        {
                            chosen.Kill();
                            chosen.WaitForExit();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибочный ввод");
                    continue;
                }

                i -= 1;
            }
        }
    }
}
