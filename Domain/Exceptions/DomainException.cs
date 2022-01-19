namespace CustomFurniture.System.Domain.Exceptions
{
    using global::System;

    public abstract class DomainException : Exception
    {
        private string? _message;

        public new string Message
        {
            get => _message ?? base.Message;
            set => _message = value;
        }
    }
}
