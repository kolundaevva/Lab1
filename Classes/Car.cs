using System;

namespace Classes
{
    public class Car: Vehicle
    {
        public string Color;
        public string BodyType;
        public string Transmission;

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
        public void setColor(string color)
        {
            Color = color;
        }
        public string getColor()
        {
            return Color;
        }
        public void getBodyType(string bodyType) {
            BodyType = bodyType;
        }
        public string setBodyType()
        {
            return BodyType;
        }
        public void getTransmission(string transmission)
        {
            Transmission = transmission;
        }
        public string setTransmission()
        {
            return Transmission;
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