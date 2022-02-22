using System;


namespace Course6.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string? message) : base(message)
        {
        }
    }
}
