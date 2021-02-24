using System;
using System.Xml.Schema;
using Classes;
using Classes.Exceptions;

namespace ConsoleApp
{
    public class Helper
    {
        private static int InputInRange(int start, int end)
        {
            int value = IntInput();
            if (value < start || value > end)
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

        public static Car carCreate()
        {
            Console.WriteLine("Введите название транспорта:");
            var name = Helper.StringInput();
            Console.WriteLine("Введите дату создания автомобиля:");
            var date = Helper.DateTimeInput();
            Console.WriteLine("Введите мощность двигателя:");
            var enginePower = Helper.InputInRange(1, 1200);
            Console.WriteLine("Введите количество посадочных мест:");
            var seatsNumber = Helper.InputInRange(2, 8);
            Console.WriteLine("Введите тип кузова:");
            var bodyType = Helper.StringInput();
            Console.WriteLine("Введите тип трансмиссии:");
            var transmission = Helper.StringInput();
            Console.WriteLine("Введите цвет авто:");
            var color = Helper.StringInput();
            Console.WriteLine("Введите VIN авто:");
            var vin = Helper.StringInput();

            return new Car(date, name, enginePower,
                seatsNumber, vin, color, 
                bodyType, transmission);
        }

        public static Train trainCreate()
        {
            Console.WriteLine("Введите название транспорта:");
            var trainName = Helper.StringInput();
            Console.WriteLine("Введите дату создания поезда:");
            var date = Helper.DateTimeInput();
            Console.WriteLine("Введите мощность двигателя:");
            var enginePower = Helper.InputInRange(1, 12000);
            Console.WriteLine("Введите количество посадочных мест:");
            var seatsNumber = Helper.InputInRange(1, 1000);;
            Console.WriteLine("Введите тип поезда:");
            var type = Helper.StringInput();
            Console.WriteLine("Введите количество вагонов:");
            var wagonCount = Helper.InputInRange(1, 100);;
            Console.WriteLine("Введите VIN авто:");
            var vin = Helper.StringInput();

            return new Train(date, trainName, enginePower,
                seatsNumber, vin, type, wagonCount);
        }

        public static Express expressCreate()
        {
            Console.WriteLine("Введите название транспорта:");
            var expressName = Helper.StringInput();
            Console.WriteLine("Введите дату создания поезда:");
            var date = Helper.DateTimeInput();
            Console.WriteLine("Введите мощность двигателя:");
            var enginePower = Helper.InputInRange(1, 12000);
            Console.WriteLine("Введите количество посадочных мест:");
            var seatsNumber = Helper.InputInRange(1, 1000);;
            Console.WriteLine("Введите тип поезда:");
            var type = Helper.StringInput();
            Console.WriteLine("Введите количество вагонов:");
            var wagonCount = Helper.InputInRange(1, 100);;
            Console.WriteLine("Введите начальную точку маршрута:");
            var startPoint = Helper.StringInput();
            Console.WriteLine("Введите конечную точку маршрута:");
            var endPoint = Helper.StringInput();
            Console.WriteLine("Введите количество остановок:");
            var stopAmount = Helper.InputInRange(1, 50);
            Console.WriteLine("Введите VIN авто:");
            var vin = Helper.StringInput();

            return new Express(date, expressName, enginePower,
                seatsNumber, vin, type, wagonCount,
                startPoint, endPoint, stopAmount);
        }
    }
}