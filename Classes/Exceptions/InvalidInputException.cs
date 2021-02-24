using System;
using System.Runtime.Serialization;

namespace Classes.Exceptions
{
    public class InvalidInputException: Exception
    {
        public InvalidInputException(string message) : base(message)
        {
        }
    }
}