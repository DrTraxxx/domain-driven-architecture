using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFurniture.System.Domain.Exceptions
{
    public class InvalidOrderException : DomainException
    {
        public InvalidOrderException()
        {
        }

        public InvalidOrderException(string message) => Message = message;
    }
}
