using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CustomFurniture.System.Domain.Common;
using CustomFurniture.System.Domain.Models.FurnitureItems;

namespace CustomFurniture.System.Domain.Models.Order
{
    public class Order : Entity<int> ,IAggregateRoot
    {
        public Order(
            DateTime deliveryDate , 
            DateTime estimatedProdTime,
            List<FurnitureItem> items , 
            Address shippingAddress , 
            int customerId,
            string note,
            OrderDetails opt)
        {
            DeliveryDate = deliveryDate;
            EstimatedProdTime = estimatedProdTime;
            OrderItems = new ReadOnlyCollection<FurnitureItem>(items);
            ShippingAddress = shippingAddress;
            CustomerId = customerId;
            Note = note;
            Options = opt;
            TotalPrice = CalculateTotal(items);
        }

        public DateTime DeliveryDate { get; }
        public DateTime EstimatedProdTime { get; }
        public ReadOnlyCollection<FurnitureItem> OrderItems { get; }
        public Address ShippingAddress { get; }
        public int CustomerId { get; }
        public decimal TotalPrice { get; }
        public string Note { get;}
        public OrderDetails Options { get;}


        private decimal CalculateTotal(IEnumerable<FurnitureItem> items , decimal  discount = 0.0m)
        {
            return items.Select(i => i.Price)
                .Aggregate(0.0m, (total, next) => total + next) - discount;
           
        }
    }
}