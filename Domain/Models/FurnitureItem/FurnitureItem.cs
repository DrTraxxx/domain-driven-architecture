using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomFurniture.System.Domain.Common;
using CustomFurniture.System.Domain.Exceptions;

namespace CustomFurniture.System.Domain.Models.FurnitureItem
{
    public class FurnitureItem : Entity<int> ,IAggregateRoot 
    {
        internal FurnitureItem(
            string name , 
            Category category , 
            Dimensions dimensions , 
            string imgUrl , 
            decimal price, 
            bool isAvailabel)
        {
            ValidateModel(name, imgUrl, price, category);

            Category = category;
            Dimensions = dimensions;  
            Name = name;
            ImageUrl = imgUrl;
            Price = price;
            IsAvailable = isAvailabel;

        }

        public string Name { get;}
        public Category Category { get;}
        public Dimensions Dimensions { get;}
        public string ImageUrl { get;}
        public decimal Price { get;}
        public bool IsAvailable { get; private set; }
        public IReadOnlyCollection<string> AvailableColors { get; }
        public string Description { get; } 

        private void ValidateModel(string name , string imgurl, decimal price , Category category) 
        {
            Guard.AgainstEmptyString<InvalidItemException>(name);
            Guard.ForValidUrl<InvalidItemException>(name);
            Guard.AgainstOutOfRange<InvalidItemException>(price, 0, decimal.MaxValue);
        }
    }
}
