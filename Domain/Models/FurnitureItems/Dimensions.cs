namespace CustomFurniture.System.Domain.Models.FurnitureItems
{
    public record Dimensions
    {
        internal Dimensions(double height, double lenght,double width)
        {
            Height = height;
            Length = lenght;
            Width = width;
        }

        public double Height { get; init; }
        public double Length { get; init; }
        public double Width { get; set; } 
    }
}
