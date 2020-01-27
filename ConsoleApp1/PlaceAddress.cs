using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PlaceAddress
    {
        private String country;
        private String city;
        private String street;
        private String number;
        private String postCode;

        public PlaceAddress (String country, String city, String street, String number, String postCode)
        {
            Country = country;
            City = city;
            Street = street;
            Number = number;
            PostCode = postCode;
        }

        public String PostCode { get => postCode; set => postCode = value; }
        public String Number { get => number; set => number = value; }
        public String Street { get => street; set => street = value; }
        public String City { get => city; set => city = value; }
        public String Country { get => country; set => country = value; }

        public String GetPlaceAddress()
        {
            return Country + City + Street + Number + PostCode;
        }
    }
}
