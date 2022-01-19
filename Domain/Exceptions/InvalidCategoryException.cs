namespace CustomFurniture.System.Domain.Exceptions
{
    public class InvalidCategoryException : DomainException
    {
        public InvalidCategoryException()
        {
        }
        public InvalidCategoryException(string message) => Message = message;
    }
}
