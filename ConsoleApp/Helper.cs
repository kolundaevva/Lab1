using System;
using System.Xml.Schema;
using Classes.Exceptions;

namespace ConsoleApp
{
    public class Helper
    {
        private static int InputInRange(int start, int end)
        {
            int value = IntInput();
            if (value < end || value > start)
            {
                throw new InvalidInputException($"Число должно быть между {start} и {end}");
            }

            return value;
        }
        public static int IntInput()
        {
            if (int.TryParse(Console.ReadLine(), out var number))
            {
                return number;
            }

            throw new InvalidInputException("Вы ввели не целое число.");
        }

        public static string StringInput()
        {
            return Console.ReadLine() ?? "nil";
        }

        public static DateTime DateTimeInput()
        {
            Console.WriteLine("Введите год:");
            int year = InputInRange(0, 2021);
            
            Console.WriteLine("Введите месяц (число):");
            int month = InputInRange(1, 12);

            Console.WriteLine("Введите день:");
            int day = InputInRange(1, 31);

            var dateTime = new DateTime(year, month, day);

            return dateTime;
        }
    }
}