using System;
using System.Collections.Generic;
using Classes;
using Classes.Exceptions;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Vehicle> list = new List<Vehicle>();
            while (true)
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
                            var car = Helper.carCreate();
                            list.Add(car);
                            break;
                        case "2":
                            var train = Helper.trainCreate();
                            list.Add(train);
                            break;
                        case "3":
                            var express = Helper.expressCreate();
                            list.Add(express);
                            break;
                        case "4":
                            var vin = Console.ReadLine();
                            var result = list.Find(item => item.VIN == vin);
                            Console.WriteLine(result.ToString());
                            Console.ReadLine();
                            break;
                        case "5":
                            return;
                    }
                }
                catch (InvalidInputException f)
                {
                    Console.WriteLine(f.Message);
                }
            }
        }
    }
}