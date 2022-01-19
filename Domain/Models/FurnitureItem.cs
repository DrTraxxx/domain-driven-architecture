using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomFurniture.System.Domain.Common;

namespace CustomFurniture.System.Domain.Models
{
    public class FurnitureItem : Entity<int> ,IAggregateRoot 
    {
        public FurnitureItem()
        {
                
        }

        public string Neme { get;}
        public Category Category { get;}
        public Dimensions Dimensions { get;}
        public string ImageUrl { get;}
        public decimal Price { get;}
        public bool IsAvailable { get; private set; }
        public IReadOnlyCollection<string> AvailableColors { get; }
        public string Description { get; }
        
    }
}
