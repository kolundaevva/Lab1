using System;

namespace Classes
{
    public class Vehicle
    {
        public DateTime CreatedAt;
        public string Name;
        public int EnginePower;
        public int SeatsNumber;
        public string VIN;

        public Vehicle(DateTime createdAt, string name, int enginePower, int seatsNumber, string vin)
        {
            CreatedAt = createdAt;
            Name = name;
            EnginePower = enginePower;
            SeatsNumber = seatsNumber;
            VIN = vin;
        }

        public DateTime getCreatedAt()
        {
            return CreatedAt;
        }

        public void setCreatedAt(DateTime createdTime)
        {
            CreatedAt = createdTime;
        }
        public string getName()
        {
            return Name;
        }

        public void setName(string name)
        {
            Name = name;
        }

        public int getEnginePower()
        {
            return EnginePower;
        }

        public void setEnginePower(int enginePower)
        {
            EnginePower = enginePower;
        }

        public int getSeatsNumber()
        {
            return SeatsNumber;
        }

        public void setSeatsNumber(int seatsNumber)
        {
            SeatsNumber = seatsNumber;
        }
        public string getVIN()
        {
            return VIN;
        }

        public void setVIN(string vin)
        {
            VIN = vin;
        }
        public string GetShortDescription()
        {
            return $"Имя: {Name}, Сделано {CreatedAt}, VIN: {VIN}";
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