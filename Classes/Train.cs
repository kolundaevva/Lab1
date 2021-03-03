using System;

namespace Classes
{
    public class Train : Vehicle
    {
        public string Type;
        public int WagonNumbers;
        public int Fare;
        public Train(
            DateTime createdAt,
            string name,
            int enginePower,
            int seatsNumber,
            string vin,
            string type,
            int wagonNumbers,
            int fare) : base(createdAt, name, enginePower, seatsNumber, vin)
        {
            Type = type;
            WagonNumbers = wagonNumbers;
            Fare = fare;
        }

        public string getType()
        {
            return Type;
        }

        public void setType(string type)
        {
            Type = type;
        }

        public int getWagonNumbers()
        {
            return WagonNumbers;
        }

        public void setWagonNumbers(int wagonNumbers)
        {
            WagonNumbers = wagonNumbers;
        }

        public int getFare()
        {
            return Fare;
        }

        public void setFare(int newFare)
        {
            Fare = newFare;
        }
        public int GetFareByPassengers(int countPassengers)
        {
            return Fare * countPassengers;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" Тип: {Type}," +
                   $" Количество вагонов: {WagonNumbers}";
        }
    }
}