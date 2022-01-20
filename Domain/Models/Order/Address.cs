using CustomFurniture.System.Domain.Common;
using CustomFurniture.System.Domain.Exceptions;

namespace CustomFurniture.System.Domain.Models.Order
{
    public record Address
    {
        internal Address(string city , string streetName, int postcode)
        {
            Validate();

            City = city;
            StreetName = streetName;
            Postcode = postcode;
            FullAddress = $"{Postcode} {City},{StreetName}";
        }

        public string City { get; init; }
        public string StreetName { get; init; }
        public int Postcode { get; init; }
        public string FullAddress { get; init; }

        private void Validate()
        {
            Guard.AgainstEmptyString<InvalidAddressException>(City,StreetName);
            Guard.AgainstOutOfRange<InvalidAddressException>(Postcode,0,10000);
        }

    }
}
