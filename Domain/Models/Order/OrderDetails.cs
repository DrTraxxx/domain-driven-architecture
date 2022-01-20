using CustomFurniture.System.Domain.Common;
using CustomFurniture.System.Domain.Exceptions;

namespace CustomFurniture.System.Domain.Models.Order
{
    public record OrderDetails
    {
        internal OrderDetails(bool isWithAssembly , string exactHourOfDelivery , bool elevatorAccessibility)
        {
            Guard.ForStringLength<InvalidOrderException>(exactHourOfDelivery, 4,8);

            IsWithAssembly = isWithAssembly;
            ExactHourOfDelivery = exactHourOfDelivery;
            ElevatorAccessibility = elevatorAccessibility;
        }

        public bool IsWithAssembly { get;}
        public string ExactHourOfDelivery { get; }
        public bool ElevatorAccessibility { get; }
        
    }
}
