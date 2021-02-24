using System;
using Classes;
using Classes.Exceptions;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить автомобиль.");
            Console.WriteLine("2. Добавить поезд");
            Console.WriteLine("3. Добавить экспресс");
            Console.WriteLine("4. Найти транспорт по VIN");
            Console.WriteLine("5. Выйти из программы");

            try
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Helper.carCreat();
                        break;
                    case "2":
                        Helper.trainCreat();
                        break;
                    case "3":
                        Helper.expressCreat();
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                }
            }
            catch(InvalidInputException f)
            {
                Console.WriteLine(f.Message);
            }
            
        }
    }
}