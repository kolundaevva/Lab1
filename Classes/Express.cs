using System;

namespace Classes
{
    public class Express : Train
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int StopAmount { get; set; }

        public Express(
            DateTime createdAt,
            string name,
            int enginePower,
            int seatsNumber,
            string vin,
            string type,
            int wagonNumbers,
            int fare,
            string startPoint,
            string endPoint,
            int stopAmount) : base(createdAt, name, enginePower, seatsNumber, vin, type, wagonNumbers, fare)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            StopAmount = stopAmount;
        }

        public void SetNewEndPoint(string endPoint, int stopAmount)
        {
            StartPoint = EndPoint;
            EndPoint = endPoint;
            StopAmount = stopAmount;
        }

        public override string ToString()
        {
            return base.ToString() + $" Начальная точка: {StartPoint}," +
                   $" Конечная точка: {EndPoint}," +
                   $" Количество остановок: {StopAmount}";
        }
    }
}