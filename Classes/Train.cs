using System;

namespace Classes
{
    public class Train : Vehicle
    {
        public string Type { get; set; }
        public int WagonNumbers { get; set; }

        public Train(
            DateTime createdAt,
            string name,
            int enginePower,
            int seatsNumber,
            string vin,
            string type,
            int wagonNumbers) : base(createdAt, name, enginePower, seatsNumber, vin)
        {
            Type = type;
            WagonNumbers = wagonNumbers;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" Тип: {Type}," +
                   $" Количество вагонов: {WagonNumbers}";
        }
    }
}