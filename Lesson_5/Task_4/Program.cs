using System;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\ExampleDir";
            string res = "Res.txt";
            File.WriteAllText(res, "ФАЙЛЫ И ПОДКАТАЛОГИ С РЕКУРССИЕЙ");
            File.AppendAllText(res, Environment.NewLine);
            File.AppendAllText(res, Environment.NewLine);
            SearchFiles(path, res);
            
        }

        static void SearchFiles(string rootFile, string resFile)
        {
            if (Directory.Exists(rootFile))
            {
                string[] directoryFiles = Directory.GetDirectories(rootFile);
                if (directoryFiles != null)
                {
                    for (int i = 0; i < directoryFiles.Length; i++)
                    {
                        if (Directory.Exists(directoryFiles[i]))
                        {

                            SearchFiles(directoryFiles[i], resFile);
                            File.AppendAllText(resFile, directoryFiles[i]);
                            File.AppendAllText(resFile, Environment.NewLine);
                        }
                        else if (File.Exists(directoryFiles[i]))
                        {
                            File.AppendAllText(resFile, directoryFiles[i]);
                            File.AppendAllText(resFile, Environment.NewLine);
                        }
                    }

                    string[] files = Directory.GetFiles(rootFile);
                    if (files != null)
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            if (Directory.Exists(files[i]))
                            {

                                SearchFiles(files[i], resFile);
                                File.AppendAllText(resFile, files[i]);
                                File.AppendAllText(resFile, Environment.NewLine);
                            }
                            else if (File.Exists(files[i]))
                            {
                                File.AppendAllText(resFile, files[i]);
                                File.AppendAllText(resFile, Environment.NewLine);
                            }
                        }
                    }
                }
            }
        }
    }
}
