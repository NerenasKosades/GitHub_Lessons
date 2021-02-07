using System;
using System.Text.Json;
using System.IO;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество задач ");
            int numTasks = Convert.ToInt32(Console.ReadLine());
            string[] Tasks = new string[numTasks];
            string jsonTasks;
            ToDo toDo = new ToDo();
            string fileName = "Res.json";
            
            for (int i = 0; i < Tasks.Length; i++)
            {
                Console.Write("Введите задачу");
                Tasks[i] = Console.ReadLine();
                toDo.title = Tasks[i];
                jsonTasks = JsonSerializer.Serialize(toDo.title);
                File.WriteAllText(fileName, jsonTasks);                
            }
            
            
            
            Console.WriteLine("");
        }



        class ToDo
        {
            public string title;
            public bool isDone;

            
        }
    }
}
