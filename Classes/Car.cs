using System;

namespace Classes
{
    public class Car: Vehicle
    {
        public string Color { get; set; }
        public string BodyType { get; set; }
        public string Transmission { get; set; }

        public Car(
            DateTime createdAt,
            string name,
            int enginePower,
            int seatsNumber,
            string vin,
            string color,
            string bodyType,
            string transmission
            ) : base(createdAt, name, enginePower, seatsNumber, vin)
        {
            Color = color;
            BodyType = bodyType;
            Transmission = transmission;
        }

        public override string ToString()
        {
            return base.ToString() + 
                   $" Цвет: {Color}," +
                   $" Кузов: {BodyType}," +
                   $" Коробка передач: {Transmission}";
        }
    }
}