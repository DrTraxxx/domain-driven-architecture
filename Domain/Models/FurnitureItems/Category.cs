using CustomFurniture.System.Domain.Common;
using CustomFurniture.System.Domain.Exceptions;

namespace CustomFurniture.System.Domain.Models.FurnitureItems
{
    public class Category : Entity<int>
    {
        internal Category(string name , string descr)
        {
            ValidateModel(name,descr);

            Name = name;
            Description = descr;
        }
        public string Name { get;}
        public string Description { get; } 

        private void ValidateModel(string name , string descr)
        {
            Guard.AgainstEmptyString<InvalidCategoryException>(name);
            Guard.ForStringLength<InvalidCategoryException>(descr, 5, 120);
        }
        
    }
}