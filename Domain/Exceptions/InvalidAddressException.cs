using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFurniture.System.Domain.Exceptions
{
    internal class InvalidAddressException : DomainException
    {
        public InvalidAddressException()
        {
        }

        public InvalidAddressException(string message) => Message = message;

    }
}
