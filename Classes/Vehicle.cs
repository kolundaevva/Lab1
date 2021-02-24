using System;

namespace Classes
{
    public class Vehicle
    {
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public int EnginePower { get; set; }
        public int SeatsNumber { get; set; }
        public string VIN { get; set; }

        public Vehicle(DateTime createdAt, string name, int enginePower, int seatsNumber, string vin)
        {
            CreatedAt = createdAt;
            Name = name;
            EnginePower = enginePower;
            SeatsNumber = seatsNumber;
            VIN = vin;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Сделано {CreatedAt}, " +
                   $"Мощность: {EnginePower}, " +
                   $"Количество сидячих мест: {SeatsNumber}, " +
                   $"VIN: {VIN}";
        }
    }
}