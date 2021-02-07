using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int num = Convert.ToInt32(Console.ReadLine());
            Mon numMonth = (Mon)num;
            Months(numMonth);
        }

        public static void Months(Mon numMon)
        {
            switch (numMon)
            {

                case Mon.January:
                {
                        Console.WriteLine("Зима");
                    break;
                }
                case Mon.February:
                    {
                        Console.WriteLine("Зима");
                        break;
                    }
                case Mon.December:
                    {
                        Console.WriteLine("Зима");
                        break;
                    }
                case Mon.March:
                    {
                        Console.WriteLine("Весна");
                        break;
                    }
                case Mon.April:
                    {
                        Console.WriteLine("Весна");
                        break;
                    }
                case Mon.May:
                    {
                        Console.WriteLine("Весна");
                        break;
                    }
                case Mon.June:
                    {
                        Console.WriteLine("Лето");
                        break;
                    }
                case Mon.July:
                    {
                        Console.WriteLine("Лето");
                        break;
                    }
                case Mon.August:
                    {
                        Console.WriteLine("Лето");
                        break;
                    }
                case Mon.September:
                    {
                        Console.WriteLine("Осень");
                        break;
                    }
                case Mon.October:
                    {
                        Console.WriteLine("Осень");
                        break;
                    }
                case Mon.November:
                    {
                        Console.WriteLine("Осень");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка: введите число от 1 до 12");
                        break;
                    }
            }
            
            
        }

        public enum Mon
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
