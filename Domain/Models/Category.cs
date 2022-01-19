using CustomFurniture.System.Domain.Common;

namespace CustomFurniture.System.Domain.Models
{
    internal class Category : Entity<int>
    {
        public string Name { get;}
        public string Description { get; set; }
        
    }
}