using System;
using System.IO;
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {           
            DateTime date = new DateTime();
            date = DateTime.Now;
            string str = date.ToString();

            string filename = "Startup.txt";

            File.AppendAllText(filename, str);
            File.AppendAllText(filename, Environment.NewLine);
        }
    }
}
