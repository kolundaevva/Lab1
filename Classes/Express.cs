using System;

namespace Classes
{
    public class Express : Train
    {
        public string StartPoint;
        public string EndPoint;
        public int StopAmount;

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

        public void setStartPoint(string startPoint)
        {
            StartPoint = startPoint;
        }
        public string getStartPoint()
        {
            return StartPoint;
        }
        public void setEndPoint(string endPoint)
        {
            EndPoint = endPoint;
        }
        public string getEndPoint()
        {
            return EndPoint;
        }
        public int getStopAmount()
        {
            return StopAmount;
        }
        public void setStopAmount(int stopAmount)
        {
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