namespace CustomFurniture.System.Domain.Exceptions
{
    public class InvalidItemException : DomainException
    {
        public InvalidItemException(){}
        public InvalidItemException(string message) => Message = message;
        
    }
}
