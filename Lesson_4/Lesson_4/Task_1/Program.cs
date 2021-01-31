using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Иванов", lastName = "Федор", patronymic = "Константинович";
            GetFullName(firstName, lastName, patronymic);
            GetFullName("Петров", "Сергей", "Вениаминович");
            GetFullName("Тарасов", lastName, "Николаевич");
        }

        public static void GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine($"{firstName} {lastName} {patronymic}");
        }
    }
}
