using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places
{
    public class PlaceAddress
    {
        private string postCode;
        private string houseNumber;
        private string street;
        private string city;
        private string country;

        public PlaceAddress(string Street, string HouseNumber, string City)
        {
            street = Street;
            HouseNumber = houseNumber;
            city = City;
        }

    }
}
